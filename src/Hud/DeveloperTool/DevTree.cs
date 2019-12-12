using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.DebugPlug;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Models;
using PoeHUD.Models.Interfaces;
using PoeHUD.Plugins;
using PoeHUD.Poe;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;
using PoeHUD.Models.Attributes;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiVector4 = System.Numerics.Vector4;
using System.IO;
using PoeHUD.Hud.Health;
using PoeHUD.Hud.UI;
using PoeHUD.Poe.Components;
using ImGuiExtension = PoeHUD.Hud.DeveloperTool.Libs.ImGuiExtension;

namespace PoeHUD.Hud.DeveloperTool
{
    public class DevTree : Plugin<DevTreeSettings>
    {
        private const string EntDebugPrefix = "EntDebug";
        private const string NearbyObjectDebugPrefix = "Nearby Objects For Debug";
        private const string LocalPlayerDebugName = "LocalPlayer";
        private const string GameControllerDebugName = "GameController";
        private const string DebugInformationName = "GameController.DebugInformation";
        private const string GameDebugName = "GameController.Game";
        private const string GameIngameStateDebugName = "GameController.Game.IngameState";
        private const string GameDataDebugName = "GameController.Game.IngameState.Data";
        private const string IngameUiDebugName = "IngameUi";
        private const string UiRootDebugName = "UIRoot";
        private const string ServerDataDebugName = "ServerData";
        public static DevTree Instance;

        public static bool addedAtlasYet;
        private List<Vector3> WorldPosDebug = new List<Vector3>();
        private List<Vector2> GridPosDebug = new List<Vector2>();

        private readonly List<(string name, object obj)> _nearbyObjectForDebug = new List<(string name, object obj)>();
        private readonly List<(string name, object obj)> _objectForDebug = new List<(string name, object obj)>();
        private List<(string text, float num)> _debugInformation = new List<(string text, float num)>();
        private readonly List<Element> _rectForDebug = new List<Element>();
        private Color _clr = Color.Pink;
        private Coroutine _coroutineRndColor;
        private bool _enableDebugHover;
        private Random _rnd;
        private DevTreeSettings _settings;
        private long _uniqueIndex;

        public DevTree(GameController gameController, Graphics graphics, DevTreeSettings settings)
            : base(gameController, graphics, settings)
        {
            _rnd = new Random((int)gameController.MainTimer.ElapsedTicks);
            _coroutineRndColor = new Coroutine(() => { _clr = new Color(_rnd.Next(255), _rnd.Next(255), _rnd.Next(255), 255); }, new WaitTime(200), nameof(DevTree), "Random Color").Run();
            Instance = this;

            GameController.Area.OnAreaChange += Area_OnAreaChange;
            ResetDebugObjects();
        }

        private void Area_OnAreaChange(AreaController obj)
        {
            ResetDebugObjects();
        }

        private void ResetDebugObjects()
        {
            _objectForDebug.Clear();
            _objectForDebug.Insert(0, (LocalPlayerDebugName, GameController.Game.IngameState.Data.LocalPlayer));
            _objectForDebug.Insert(1, (GameControllerDebugName, GameController));
            _objectForDebug.Insert(2, (GameDebugName, GameController.Game));
            _objectForDebug.Insert(3, (DebugInformationName, GameController.DebugInformation));
            _objectForDebug.Insert(4, (GameIngameStateDebugName, GameController.Game.IngameState));
            _objectForDebug.Insert(5, (GameDataDebugName, GameController.Game.IngameState.Data));
            _objectForDebug.Insert(6, (IngameUiDebugName, GameController.Game.IngameState.IngameUi));
            _objectForDebug.Insert(7, (UiRootDebugName, GameController.Game.IngameState.UIRoot));
            _objectForDebug.Insert(8, (ServerDataDebugName, GameController.Game.IngameState.ServerData));
        }

        public override void Render()
        {
            if (Settings.ToggleDraw.PressedOnce())
                Settings.Opened = !Settings.Opened;

            if (!Settings.Opened) return;

            RenderDebugInformation();
            RenderNearestObjectsDebug();

            foreach (var pos in WorldPosDebug)
            {
                var screenPos = GameController.Game.IngameState.Camera.WorldToScreen(pos, GameController.Player);
                var imgSize = 50;
                Graphics.DrawPluginImage(@"textures\ms-red.png", new RectangleF(screenPos.X - imgSize / 2, screenPos.Y - imgSize / 2, imgSize, imgSize));
            }

            foreach (var pos in GridPosDebug)
            {
                var worldP = pos.GridToWorld();
                var world3 = new Vector3(worldP.X, worldP.Y, GameController.Player.Pos.Y);
                var screenPos = GameController.Game.IngameState.Camera.WorldToScreen(world3, GameController.Player);
                var imgSize = 50;
                Graphics.DrawPluginImage(@"textures\ms-red.png", new RectangleF(screenPos.X - imgSize / 2, screenPos.Y - imgSize / 2, imgSize, imgSize));
            }
        }

        public void AddNearestObjectsDebug()
        {
            var playerPos = GameController.Player.Pos;
            var entsToDebug = GameController.EntityListWrapper.Entities.Where(x => Vector3.Distance(x.Pos, playerPos) < Settings.NearestEntsRange.Value).ToList();
            foreach (var ent in entsToDebug)
            {
                if (_nearbyObjectForDebug.Any(x => Equals(x.obj, ent))) continue;
                _nearbyObjectForDebug.Add(($"{EntDebugPrefix} [{_nearbyObjectForDebug.Count + 1}], {ent.Path}", ent));
            }
        }
        public void DebugInformation()
        {
            List<(string text, float num)> _debugInformationTemp = new List<(string text, float num)>();
            foreach (var dbinfo in GameController.DebugInformation)
            {
                _debugInformationTemp.Add((dbinfo.Key, dbinfo.Value));
            }

            _debugInformation = _debugInformationTemp;
        }

        private void RenderNearestObjectsDebug()
        {
            if (Settings.DebugNearestEnts.PressedOnce())
                AddNearestObjectsDebug();
            foreach (var (name, obj) in _nearbyObjectForDebug)
            {
                if (!name.StartsWith(EntDebugPrefix)) continue;
                var entWrapper = obj as EntityWrapper;
                var screenDrawPos = GameController.Game.IngameState.Camera.WorldToScreen(entWrapper.Pos, entWrapper);
                var label = name; // entWrapper.Address.ToString("x");
                label = label.Substring(label.IndexOf("[") + 1);
                label = label.Substring(0, label.IndexOf("]"));
                const FontDrawFlags drawFlags = FontDrawFlags.Center | FontDrawFlags.VerticalCenter;
                const int textSize = 20;
                var labelSize = Graphics.MeasureText(label, textSize, drawFlags);
                labelSize.Width += 10;
                labelSize.Height += 2;
                Graphics.DrawBox(new RectangleF(screenDrawPos.X - labelSize.Width / 2, screenDrawPos.Y - labelSize.Height / 2, labelSize.Width, labelSize.Height), Color.Black);
                Graphics.DrawText(label, textSize, screenDrawPos, drawFlags);
            }
        }

        private void RenderDebugInformation()
        {
            _uniqueIndex = 0;
            var idPop = 1;

            var indexCounter = 0;
            foreach (var rectangleF in _rectForDebug)
            {
                var rect = rectangleF.GetClientRect();
                Graphics.DrawFrame(rect, 2, _clr);
                Graphics.DrawText(indexCounter.ToString(), 15, rect.TopLeft, FontDrawFlags.Top | FontDrawFlags.Left);
                indexCounter++;
            }



            var isOpened = Settings.Opened;
            ImGuiExtension.BeginWindow($"DevTree Settings", ref isOpened, Settings.LastSettingPos.X, Settings.LastSettingPos.Y, Settings.LastSettingSize.X, Settings.LastSettingSize.Y);
            Settings.Opened = isOpened;

            ImGuiNative.igGetContentRegionAvail(out var newcontentRegionArea);
            ImGui.BeginChild("RightSettings", new ImGuiVector2(newcontentRegionArea.X, newcontentRegionArea.Y), true, WindowFlags.Default);

            Settings.NearestEntsRange.Value = ImGuiExtension.IntSlider("Nearest Ents Debug Range", Settings.NearestEntsRange.Value, Settings.NearestEntsRange.Min, Settings.NearestEntsRange.Max);

            if (ImGui.Button("Clear Debug Rectangles##base")) _rectForDebug.Clear();
            ImGui.SameLine();
            if (ImGui.Button("Clear Debug Objects##base"))
            {
                _objectForDebug.Clear();
                _nearbyObjectForDebug.Clear();
                ResetDebugObjects();
            }

            ImGui.SameLine();
            if (ImGui.Button("Clear Pos Debug##base"))
            {
                WorldPosDebug.Clear();
                GridPosDebug.Clear();
            }

            ImGui.SameLine();
            ImGui.Checkbox("F1 To Debug HoverUI", ref _enableDebugHover);
            if (_enableDebugHover && WinApi.IsKeyDown(Keys.F1))
            {
                // Do nothing, not supported
            }

            if (WinApi.IsKeyDown(Settings.DebugHoverItem))
            {
                // Do nothing, not supported
            }

            for (var i = 0; i < _objectForDebug.Count; i++)
                if (ImGui.TreeNode($"{_objectForDebug[i].name}##{_uniqueIndex}"))
                {
                    ImGuiNative.igIndent();
                    DebugForImgui(_objectForDebug[i].obj);
                    ImGuiNative.igUnindent();
                    ImGui.TreePop();
                }

            if (ImGui.TreeNode($"Debug Information##{_uniqueIndex}"))
            {
                DebugInformation();
                if (_debugInformation.Count < 1)
                {
                    ImGui.TreePop();
                    _uniqueIndex++;
                }
                else
                {
                    ImGuiNative.igIndent();
                    foreach (var item in _debugInformation)
                    {
                        _uniqueIndex++;
                        ImGui.Text($"{item.text}:", new ImGuiVector4(1, 0.412f, 0.706f, 1));
                        ImGui.SameLine();

                        ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                        ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                        ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                        ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                        if (ImGui.SmallButton($"{item.num}##{_uniqueIndex++}"))
                            ImGuiNative.igSetClipboardText(item.num.ToString());
                        ImGui.PopStyleColor(4);
                        _uniqueIndex++;
                    }
                    ImGuiNative.igUnindent();
                    ImGui.TreePop();
                }
            }

            if (ImGui.TreeNode($"{NearbyObjectDebugPrefix} [{_nearbyObjectForDebug.Count}]##{_uniqueIndex}"))
            {
                NearObjectsToDebugButton();
                for (var i = 0; i < _nearbyObjectForDebug.Count; i++)
                    if (ImGui.TreeNode($"{_nearbyObjectForDebug[i].name}##{_uniqueIndex}"))
                    {
                        ImGuiNative.igIndent();
                        DebugForImgui(_nearbyObjectForDebug[i].obj);
                        ImGuiNative.igUnindent();
                        ImGui.TreePop();
                    }

                ImGui.TreePop();
            }
            else
                NearObjectsToDebugButton();

            ImGui.EndChild();

            // Storing window Position and Size changed by the user
            if (ImGui.GetWindowHeight() > 21)
            {
                Settings.LastSettingPos = ImGui.GetWindowPosition();
                Settings.LastSettingSize = ImGui.GetWindowSize();
            }

            ImGui.EndWindow();
        }

        public void NearObjectsToDebugButton()
        {
            ImGui.SameLine();
            if (ImGui.SmallButton("Add Nearby Objects")) AddNearestObjectsDebug();
        }

        private void DebugForImgui(object obj)
        {
            #region Static offset fields with Attribute Debug 

            const BindingFlags staticFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            if (obj != null)
            {
                var staticFields = obj.GetType().GetFields(staticFlags).Where(x => x.GetCustomAttributes(false).Any(y => y is StaticOffsetFieldDebugAttribute));

                foreach (var fInfo in staticFields)
                {
                    if (fInfo.FieldType != typeof(int))
                    {
                        ImGui.Text($"Error in debug {fInfo.Name}: Should be int field");
                        continue;
                    }

                    var arrt = fInfo.GetCustomAttribute<StaticOffsetFieldDebugAttribute>();

                    var fieldValue = (int)fInfo.GetValue(null);

                    if (ImGui.SliderInt($"{fInfo.Name}=0x{fieldValue:X}", ref fieldValue, arrt.SliderMin, arrt.SliderMax, "%.00f"))
                    {
                        fInfo.SetValue(null, fieldValue);
                    }
                }
            }

            #endregion

            const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            try
            {
                if (obj is IEntity)
                {
                    Dictionary<string, long> comp;
                    object ro;
                    if (obj is EntityWrapper wrapper)
                    {
                        ro = wrapper;
                        comp = wrapper.InternalEntity.GetComponents();
                    }
                    else
                    {
                        ro = (Entity)obj;
                        comp = ((Entity)obj).GetComponents();
                    }

                    if (ImGui.TreeNode($"Components {comp.Count} ##{ro.GetHashCode()}"))
                    {
                        var method = ro is EntityWrapper ? typeof(EntityWrapper).GetMethod("GetComponent") : typeof(Entity).GetMethod("GetComponent");

                        foreach (var c in comp)
                        {
                            ImGui.Text(c.Key, new ImGuiVector4(1, 0.412f, 0.706f, 1));
                            ImGui.SameLine();
                            var type = Type.GetType("PoeHUD.Poe.Components." + c.Key + ", PoeHUD, Version=6.3.9600.0, Culture=neutral, PublicKeyToken=null");
                            if (type == null)
                            {
                                ImGui.Text(" - undefiend", new ImGuiVector4(1, 0.412f, 0.706f, 1));

                                ImGui.SameLine();
                                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                                ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                                ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                                ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                                if (ImGui.SmallButton($"{c.Value:x}##{_uniqueIndex++}"))
                                    ImGuiNative.igSetClipboardText(c.Value.ToString("x"));
                                ImGui.PopStyleColor(4);

                                continue;
                            }

                            if (method == null) continue;
                            var generic = method.MakeGenericMethod(type);
                            var g = generic.Invoke(ro, null);
                            if (!ImGui.TreeNode($"##{ro.GetHashCode()}{c.Key.GetHashCode()}")) continue;
                            _uniqueIndex++;
                            if (ImGui.SmallButton($"Debug this##{_uniqueIndex}"))
                            {
                                var formattableString = $"{obj}->{c.Key} ({c.Value:x})";
                                if (_objectForDebug.Any(x => x.name.Contains(formattableString)))
                                {
                                    var findIndex = _objectForDebug.FindIndex(x => x.name.Contains(formattableString));
                                    _objectForDebug[findIndex] = (formattableString + "^", g);
                                }
                                else
                                    _objectForDebug.Add((formattableString, g));
                            }

                            DebugForImgui(g);
                            ImGui.TreePop();
                        }

                        ImGui.TreePop();
                    }
                }

                if (obj is Element el1)
                {
                    ImGui.SameLine();
                    _uniqueIndex++;
                    if (ImGui.SmallButton($"Draw this##{_uniqueIndex}"))
                        _rectForDebug.Add(el1);
                    ImGui.SameLine();
                    _uniqueIndex++;
                    if (ImGui.SmallButton($"Clear##from draw this{_uniqueIndex}")) _rectForDebug.Clear();


                    var indexPath = new List<int>();
                    var iterator = el1;
                    while (iterator.Address != 0)
                    {
                        if (iterator.Parent.Address != 0)
                            indexPath.Add(iterator.Parent.Children.FindIndex(x => x.Address == iterator.Address));
                        iterator = iterator.Parent;
                    }

                    indexPath.Reverse();
                    ImGui.Text($"Path from root: [{string.Join(", ", indexPath)}]");
                    _uniqueIndex++;
                }

                if (obj is Entity normalInvItem)
                {
                    if (!normalInvItem.HasComponent<Base>()) return;
                    _uniqueIndex++;
                    if (ImGui.TreeNode($"Base Component##{normalInvItem.Id}{_uniqueIndex}"))
                    {
                        DebugProperty(typeof(Base), normalInvItem.GetComponent<Base>());
                        ImGui.TreePop();
                    }

                    _uniqueIndex++;
                    if (ImGui.TreeNode($"Base Item Type Info##{normalInvItem.Id}{_uniqueIndex}"))
                    {
                        var BIT = GameController.Files.BaseItemTypes.Translate(normalInvItem.Path);
                        DebugProperty(typeof(BaseItemType), BIT);
                        ImGui.TreePop();
                    }
                }


                var oProp = obj.GetType().GetProperties(flags).Where(x => x.GetIndexParameters().Length == 0);
                var ordered1 = oProp.OrderBy(x => x.PropertyType.GetInterfaces().Contains(typeof(IEnumerable))); //We want to show arrays and lists last
                oProp = ordered1.ThenBy(x => x.Name).ToList();
                foreach (var propertyInfo in oProp)
                {
                    if (propertyInfo.GetCustomAttribute<HideInReflectionAttribute>() != null) continue;

                    if (propertyInfo.ReflectedType.IsSubclassOf(typeof(RemoteMemoryObject))) //We don't need to see this shit
                        if (propertyInfo.Name == "M" || propertyInfo.Name == "Game" || propertyInfo.Name == "Offsets")
                            continue;
                    if (propertyInfo.ReflectedType.IsSubclassOf(typeof(Component))) //...and this one too
                        if (propertyInfo.Name == "Owner")
                            continue;
                    try
                    {
                        var value = propertyInfo.GetValue(obj, null);


                        if (
                                //propertyInfo.GetValue(obj, null).GetType().IsPrimitive  //Wanna get null or what?
                                propertyInfo.PropertyType.IsPrimitive || value is decimal || value is string || value is TimeSpan || value is Enum ||
                                value is Vector3 || value is Vector3)
                        {
                            ImGui.Text($"{propertyInfo.Name}: ");
                            ImGui.SameLine(0f, 0f);
                            var o = propertyInfo.GetValue(obj, null);
                            if (propertyInfo.Name.Contains("Address"))
                                o = Convert.ToInt64(o).ToString("X");

                            //if (!propertyInfo.Name.Contains("Address")) continue; //We want to copy any thing we need
                            ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                            ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                            ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                            ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                            if (ImGui.SmallButton($"{o}##{o}{o.GetHashCode()}"))
                                ImGuiNative.igSetClipboardText(o.ToString());
                            ImGui.PopStyleColor(4);
                        }
                        else
                        {
                            var label = propertyInfo.Name;
                            if (value == null)
                            {
                                ImGui.Text(label + ": ");
                                ImGui.SameLine(0f, 0f);
                                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.366f, 0.366f, 1));
                                ImGui.Text("Null");
                                ImGui.PopStyleColor(1);
                                continue;
                            }


                            if (label.Contains("Framework") || label.Contains("Offsets"))
                                continue;



                            if (propertyInfo.PropertyType == typeof(Vector2) || propertyInfo.PropertyType == typeof(Vector3))
                            {
                                ImGui.Text($"{propertyInfo.Name}: ");
                                ImGui.SameLine();
                                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                                ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                                ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                                ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));

                                var typeName = value.GetType().Name;
                                var displayLabel = $"({value})";

                                if (ImGui.SmallButton($"{displayLabel}##{_uniqueIndex++}"))
                                    ImGuiNative.igSetClipboardText(value.ToString());
                                ImGui.PopStyleColor(4);

                                ImGui.SameLine();
                                if (ImGui.SmallButton($"Debug world pos##{_uniqueIndex++}"))
                                {
                                    if (value is Vector3)
                                        WorldPosDebug.Add((Vector3)value);
                                    else
                                    {
                                        var v2 = (Vector2)value;
                                        WorldPosDebug.Add(new Vector3(v2.X, v2.Y, GameController.Player.Pos.Z));
                                    }
                                }
                                if (value is Vector2)
                                {
                                    ImGui.SameLine();
                                    if (ImGui.SmallButton($"Debug grid pos##{_uniqueIndex++}"))
                                    {
                                        GridPosDebug.Add((Vector2)value);
                                    }
                                }

                                continue;
                            }


                            if (!propertyInfo.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
                            {
                                if (ImGui.TreeNode($"{label}##{_uniqueIndex}"))
                                {
                                    _uniqueIndex++;
                                    ImGui.SameLine();

                                    if (ImGui.SmallButton($"Debug this##{_uniqueIndex}"))
                                    {
                                        var formattable = $"{label}->{value} ({value.GetHashCode()})";
                                        if (_objectForDebug.Any(x => x.name.Contains(formattable)))
                                        {
                                            var findIndex = _objectForDebug.FindIndex(x => x.name.Contains(formattable));
                                            _objectForDebug[findIndex] = (formattable + "^", value);
                                        }
                                        else
                                            _objectForDebug.Add((formattable, value));
                                    }


                                    ImGuiNative.igIndent();
                                    DebugForImgui(value);
                                    ImGuiNative.igUnindent();
                                    ImGui.TreePop();
                                }
                                else if (string.IsNullOrEmpty(value.ToString()) && value.ToString() != propertyInfo.PropertyType.FullName)//display ToString overrided clases
                                {
                                    ImGui.SameLine();
                                    ImGui.Text($": {value}", new ImGuiVector4(0.486f, 0.988f, 0, 1));
                                }
                                continue;
                            }

                            if (ImGui.TreeNode($"{propertyInfo.Name}:##{_uniqueIndex}")) //Hide arrays to tree node
                            {
                                var enumerable = (IEnumerable)value;
                                var items = enumerable as IList<object> ?? enumerable.Cast<object>().ToList();
                                var gArgs = value.GetType().GenericTypeArguments.ToList();
                                if (gArgs.Any(x => x == typeof(Element) || x.IsSubclassOf(typeof(Element)))) //We need to draw it ONLY for UI Elements
                                {
                                    _uniqueIndex++;
                                    if (ImGui.SmallButton($"Draw Childs##{_uniqueIndex}"))
                                    {
                                        var tempi = 0;
                                        foreach (var item in items)
                                        {
                                            var el = (Element)item;
                                            _rectForDebug.Add(el);
                                            tempi++;
                                            if (tempi > 1000) break;
                                        }
                                    }

                                    ImGui.SameLine();
                                    _uniqueIndex++;
                                    if (ImGui.SmallButton($"Draw Childs for Childs##{_uniqueIndex}")) DrawChilds(items);
                                    ImGui.SameLine();
                                    _uniqueIndex++;
                                    if (ImGui.SmallButton($"Draw Childs for Childs Only Visible##{_uniqueIndex}")) DrawChilds(items, true);
                                    ImGui.SameLine();
                                    _uniqueIndex++;
                                    if (ImGui.SmallButton($"Clear##from draw childs##{_uniqueIndex}")) _rectForDebug.Clear();
                                }

                                var i = 0;
                                foreach (var item in items)
                                {
                                    if (item == null)
                                    {
                                        ImGui.Text($"   [{i}]");
                                        ImGui.SameLine();
                                        ImGui.Text($"Null", new ImGuiVector4(0.486f, 0.988f, 0, 1));
                                        i++;
                                        continue;
                                    }
                                    _uniqueIndex++;


                                    var subItemType = item.GetType();

                                    if (item is string || subItemType.IsPrimitive)
                                    {
                                        ImGui.Text($"   [{i}]");
                                        ImGui.SameLine(0f, 0f);
                                        var o = item;
                                        //if (!propertyInfo.Name.Contains("Address")) continue; //We want to copy any thing we need
                                        ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                                        ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                                        ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                                        ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                                        if (ImGui.SmallButton($"{o}##{o}{o.GetHashCode()}"))
                                            ImGuiNative.igSetClipboardText(o.ToString());
                                        ImGui.PopStyleColor(4);
                                        i++;
                                        continue;
                                    }
                                    if (Settings.LimitEntriesDrawn.Value && i > Settings.EntriesDrawLimit.Value) break;
                                    if (ImGui.TreeNode($"[{i}]##{_uniqueIndex}")) //Draw only index
                                    {
                                        ImGui.SameLine();
                                        ImGui.Text($"{item}", new ImGuiVector4(0.486f, 0.988f, 0, 1));

                                        if (item is Element element1)
                                        {
                                            ImGui.SameLine();
                                            ImGui.SmallButton($"Show##from draw this{_uniqueIndex}");

                                            if (ImGui.IsItemHovered(HoveredFlags.Default))
                                            {
                                                var rect = element1.GetClientRect();
                                                Graphics.DrawFrame(rect, 2, _clr);
                                            }
                                        }
                                        DebugForImgui(item);
                                        ImGui.TreePop();
                                    }
                                    else
                                    {

                                        if (!string.IsNullOrEmpty(item.ToString()) && item.ToString() != item.GetType().FullName)
                                        {
                                            ImGui.SameLine();
                                            ImGui.Text($"{item}", new ImGuiVector4(0.486f, 0.988f, 0, 1));
                                        }
                                        else
                                        {
                                            ImGui.SameLine();
                                            ImGui.Text($"{item.GetType().Name}", new ImGuiVector4(0.486f, 0.988f, 0, 1));
                                        }


                                        if (item is Element element1)
                                        {
                                            ImGui.SameLine();
                                            ImGui.SmallButton($"Show##from draw this{_uniqueIndex}");

                                            if (ImGui.IsItemHovered(HoveredFlags.Default))
                                            {
                                                var rect = element1.GetClientRect();
                                                Graphics.DrawFrame(rect, 2, _clr);
                                            }
                                        }
                                    }

                                    i++;
                                }
                                ImGuiNative.igUnindent();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ImGui.Text($"Error reading property: {propertyInfo.Name}, Error: {ex}", new ImGuiVector4(1, 0, 0, 1));
                    }
                }
            }
            catch (Exception e)
            {
                DebugPlugin.LogMsg($"Debug Tree: {e}", 1);
            }
        }


        private void DebugProperty(Type type, object instance)
        {
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                if (prop.GetCustomAttribute<HideInReflectionAttribute>() != null) continue;

                _uniqueIndex++;
                object value = null;
                Exception Ex = null;
                try
                {
                    value = prop.GetValue(instance);
                }
                catch (Exception ex)
                {
                    Ex = ex;
                }

                ImGui.Text($"{prop.Name}: ");
                ImGui.SameLine(0f, 0f);
                var o = prop.GetValue(instance, null);
                if (prop.Name.Contains("Address"))
                    o = Convert.ToInt64(o).ToString("X");
                //if (!propertyInfo.Name.Contains("Address")) continue; //We want to copy any thing we need
                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                if (ImGui.SmallButton($"{o}##{o}{o.GetHashCode()}"))
                    ImGuiNative.igSetClipboardText(o.ToString());
                ImGui.PopStyleColor(4);
            }

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if (field.GetCustomAttribute<HideInReflectionAttribute>() != null) continue;

                _uniqueIndex++;
                object value = null;
                Exception Ex = null;
                try
                {
                    value = field.GetValue(instance);
                }
                catch (Exception ex)
                {
                    Ex = ex;
                }

                ImGui.Text($"{field.Name}: ");
                ImGui.SameLine(0f, 0f);
                var o = field.GetValue(instance);
                if (field.Name.Contains("Address"))
                    o = Convert.ToInt64(o).ToString("X");
                //if (!propertyInfo.Name.Contains("Address")) continue; //We want to copy any thing we need
                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(1, 0.647f, 0, 1));
                ImGui.PushStyleColor(ColorTarget.Button, new ImGuiVector4(0, 0, 0, 0));
                ImGui.PushStyleColor(ColorTarget.ButtonHovered, new ImGuiVector4(0.25f, 0.25f, 0.25f, 1));
                ImGui.PushStyleColor(ColorTarget.ButtonActive, new ImGuiVector4(1, 1, 1, 1));
                if (ImGui.SmallButton($"{o}##{o}{o.GetHashCode()}"))
                    ImGuiNative.igSetClipboardText(o.ToString());
                ImGui.PopStyleColor(4);
            }
        }

        private void DrawChilds(object obj, bool onlyVisible = false)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            if (obj is IEnumerable enumerable)
            {
                var tempi = 0;
                foreach (var item in enumerable)
                {
                    var el = (Element)item;
                    if (onlyVisible)
                        if (!el.IsVisible)
                            continue;
                    _rectForDebug.Add(el);
                    tempi++;
                    if (tempi > 1000) break;
                    var oProp = item.GetType().GetProperties(flags).Where(x => x.GetIndexParameters().Length == 0);
                    foreach (var propertyInfo in oProp) DrawChilds(propertyInfo.GetValue(item, null));
                }
            }
            else
            {
                if (obj is Element el)
                    _rectForDebug.Add(el);
            }
        }

        /*
        private void DebugImGuiFields(object obj)
        {
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            var fields = obj.GetType().GetFields(flags);
            foreach (var fieldInfo in fields)
            {
                ImGui.PushStyleColor(ColorTarget.Text, new ImGuiVector4(0.529f, 0.808f, 0.922f, 1));
                ImGui.Text($"{fieldInfo.Name} -=> {fieldInfo.GetValue(obj)}");
                ImGui.PopStyleColor();
            }
        }
        */
    }
}
