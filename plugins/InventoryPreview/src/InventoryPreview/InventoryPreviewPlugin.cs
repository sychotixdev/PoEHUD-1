using PoeHUD.Controllers;
using PoeHUD.Framework.Helpers;
using PoeHUD.Framework.InputHooks;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphics = PoeHUD.Hud.UI.Graphics;
using RectangleF = SharpDX.RectangleF;
using PoeHUD.Plugins;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.EntityComponents;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using Color = SharpDX.Color;
using System.Runtime.InteropServices;

namespace InventoryPreview
{
    public class InventoryPreviewPlugin : BaseSettingsPlugin<InventoryPreviewSettings>
    {
        private const int CELLS_X_COUNT = 12;
        private const int CELLS_Y_COUNT = 5;

        private CellData[,] cells;
        private IngameUIElements ingameUiElements;
        private Action<MouseInfo> onMouseDown;

        public override void Initialise()
        {
            PluginName = "Inventory Preview";
            MouseHook.MouseDown += onMouseDown = info => info.Handled = OnMouseEvent(info);
            cells = new CellData[CELLS_X_COUNT, CELLS_Y_COUNT];
        }
        
        private bool CellDrawFlag = false;//Don't draw already drawn cells flag

        private bool Initialised = false;
        public override void Render()
        {
            ingameUiElements = GameController.Game.IngameState.IngameUi;
            if (ingameUiElements.OpenLeftPanel.IsVisible || ingameUiElements.OpenRightPanel.IsVisible)
            {
                if (ingameUiElements.InventoryPanel.IsVisible)
                {
                    Initialised = true;
                    cells = new CellData[CELLS_X_COUNT, CELLS_Y_COUNT];
                    AddItems();
                }
                return;
            }

            RectangleF rect = GameController.Window.GetWindowRectangle();
            float xPos = rect.Width * Settings.PositionX * .01f;
            float yPos = rect.Height * Settings.PositionY * .01f;
            var startDrawPoint = new Vector2(xPos, yPos);

            if(!Initialised)
            {
                Graphics.DrawText("Open inventory for initial synchronisation...", 15, startDrawPoint - new Vector2(-10, 20), Color.Red, SharpDX.Direct3D9.FontDrawFlags.Left);
            }
            
            CellDrawFlag = !CellDrawFlag;
            for (int x = 0; x < CELLS_X_COUNT; x++)
            {
                for (int y = 0; y < CELLS_Y_COUNT; y++)
                {
                    DrawItem(x, y, startDrawPoint);
                }
            }
        }
        private void DrawItem(int x, int y, Vector2 startDrawPoint)
        {
            CellData cell = cells[x, y];

            if (cell.IsDrawn_Flag == CellDrawFlag)
                return;

            if (cell.ItemSizeX == 0)
                cell.ItemSizeX = 1;
            if (cell.ItemSizeY == 0)
                cell.ItemSizeY = 1;

            Vector2 d = startDrawPoint.Translate(x * Settings.CellSize, y * Settings.CellSize);
            float cellWidth = GetCellSize(cell.ItemSizeX);
            float cellHeight = GetCellSize(cell.ItemSizeY);
            var rectangleF = new RectangleF(d.X, d.Y, cellWidth, cellHeight);

            Graphics.DrawImage("cell.png", rectangleF, cell.IsUsed ? Settings.CellUsedColor : Settings.CellFreeColor);

            if (cell.IsUsed)
            {
                if (!string.IsNullOrEmpty(cell.IconMetadata))
                {
                    var getImg = GetImage(cell.IconMetadata);

                    if (getImg.bIsDownloaded)
                    {
                        Graphics.DrawPluginImage(getImg.FilePath, rectangleF);
                    }
                }
                if (cell.IsStackable)
                {
                    int textSize = (int)(Settings.CellSize / 2.7f);
                    var textPos = rectangleF.Center;
                    textPos -= new Vector2(0, textSize / 2);

                    float backgroundSize = Settings.CellSize / 2;
                    var backgroundRect = new RectangleF(rectangleF.Center.X - backgroundSize, rectangleF.Center.Y - backgroundSize / 2, backgroundSize * 2, backgroundSize);

                    float offset = textSize / 1.5f;
                    backgroundRect.Y += offset;
                    textPos.Y += offset;

                    Graphics.DrawImage("menu-colors.png", backgroundRect, Settings.BackgroundColor);
                    var color = cell.CurrentStackSize == cell.MaxStackSize ? new Color(0, 186, 154) : Color.White;

                    Graphics.DrawText(cell.CurrentStackSize.ToString(), textSize, textPos, color, SharpDX.Direct3D9.FontDrawFlags.Center);
                }
            }
        

            //Don't draw cells that already drawn for this item
            for (int i = x; i < x + cell.ItemSizeX; i++)
            {
                for (int j = y; j < y + cell.ItemSizeY; j++)
                {
                    cells[i, j].IsDrawn_Flag = CellDrawFlag;
                }
            }
        }


        private float GetCellSize(int size)
        {
            return (Settings.CellSize * size) - Settings.CellPadding;
        }

        private void AddItems()
        {
            var inventoryZone = ingameUiElements.ReadObject<Element>(ingameUiElements.InventoryPanel.Address + Element.OffsetBuffers + 0x42C);

            foreach (Element element in inventoryZone.Children)
            {
                InventoryItemIcon inventElement = element.AsObject<InventoryItemIcon>();

                if (inventElement.InventPosX < 0 || inventElement.InventPosX >= CELLS_X_COUNT || inventElement.InventPosY < 0 || inventElement.InventPosY >= CELLS_Y_COUNT)
                {
                    continue;
                }

                var item = inventElement.Item;
                if (item != null)
                {
                    AddItem(inventElement.InventPosX, inventElement.InventPosY, item);
                }
            }
        }

        private void AddItem(int x, int y, Entity item)
        {
            var rendertItem = item.GetComponent<RenderItem>();

            var baseC = item.GetComponent<Base>();
            var itemSizeX = baseC.ItemCellsSizeX;
            var itemSizeY = baseC.ItemCellsSizeY;

            bool stackable = false;
            string itemName = "";
            int stackSize = 0;
            int maxStackSize = 0;

            var stack = item.GetComponent<Stack>();
            if (stack != null && stack.Info != null)
            {
                stackable = true;
                BaseItemType bit = GameController.Files.BaseItemTypes.Translate(item.Path);
                itemName = bit.BaseName;
                stackSize = stack.Size;
                maxStackSize = stack.Info.MaxStackSize;
            }
            AddItemToCells(x, y, itemSizeX, itemSizeY, stackable, itemName, stackSize, maxStackSize, rendertItem.ResourcePath);
        }

        private long CurPickItemCount = 0;
        private bool OnMouseEvent(MouseInfo mouseInfo)
        {
            try
            {
                if (!Settings.Enable || !Settings.AutoUpdate || !GameController.Window.IsForeground() || mouseInfo.Buttons != MouseButtons.Left)
                {
                    return false;
                }
                Element uiHover = GameController.Game.IngameState.UIHover;
                var inventoryItemIcon = uiHover.AsObject<InventoryItemIcon>();

                if (inventoryItemIcon.ToolTipType == ToolTipType.ItemOnGround)
                {
                    var item = inventoryItemIcon.Item;

                    var rendertItem = item.GetComponent<RenderItem>();

                    bool stackable = false;
                    string itemName = "";
                    int stackSize = 0;
                    int maxStackSize = 0;
                    string resourcePath = rendertItem.ResourcePath;

                    var stack = item.GetComponent<Stack>();
                    if (stack != null && stack.Info != null)
                    {
                        stackable = true;
                        BaseItemType bit = GameController.Files.BaseItemTypes.Translate(item.Path);
                        itemName = bit.BaseName;
                        stackSize = stack.Size;
                        maxStackSize = stack.Info.MaxStackSize;
                    }

                    var baseC = item.GetComponent<Base>();

                    int ItemCellsSizeX = baseC.ItemCellsSizeX;
                    int ItemCellsSizeY = baseC.ItemCellsSizeY;

                    CurPickItemCount++;

                    Task.Factory.StartNew(async () =>
                    {
                        long curItemPickCount = CurPickItemCount;
                        Stopwatch sw = Stopwatch.StartNew();
                        while (item.IsValid)
                        {
                            await Task.Delay(30);

                            //We want to prevent the item was added more than once
                            if (curItemPickCount != CurPickItemCount)
                                return;

                            if (sw.ElapsedMilliseconds <= 10000) continue;
                            sw.Stop();
                            break;
                        }

                        //We want to prevent the item was added more than once
                        if (curItemPickCount != CurPickItemCount)
                            return;

                        if (!item.IsValid)
                        {
                            TryToAutoAddItem(itemName, stackable, stackSize, maxStackSize, ItemCellsSizeX, ItemCellsSizeY, resourcePath);
                        }
                    });

                }
            }
            catch (Exception e)
            {
                LogError("OnMouseEvent error: " + e.Message, 4);
                return false;
            }
            return true;
        }


        private bool TryToAutoAddItem(string itemName, bool stackable, int currentStackSize, int maxStackSize, int itemSizeX, int itemSizeY, string iconMetadata)
        {
            if (stackable)
            {
                //first of all we will try to find same stacks and increase them. If some part of stack still present- we will find free space for it in the next step.
                for (int x = 0; x + itemSizeX <= CELLS_X_COUNT; x++)
                {
                    for (int y = 0; y + itemSizeY <= CELLS_Y_COUNT; y++)
                    {
                        var cell = cells[x, y];

                        if (cell.IsStackable && cell.IsUsed)
                        {
                            if (cell.CurrentStackSize < cell.MaxStackSize && cell.ItemName == itemName)
                            {
                                cells[x, y].CurrentStackSize += currentStackSize;
                                currentStackSize = cells[x, y].CurrentStackSize - cell.MaxStackSize;

                                if (cells[x, y].CurrentStackSize > cell.MaxStackSize)
                                    cells[x, y].CurrentStackSize = cell.MaxStackSize;

                                if (currentStackSize <= 0)
                                    return true;

                            }
                        }

                    }
                }
            }

            //Not stackable or just find free space for it
            for (int x = 0; x + itemSizeX <= CELLS_X_COUNT; x++)
            {
                for (int y = 0; y + itemSizeY <= CELLS_Y_COUNT; y++)
                {
                    var cell = cells[x, y];

                    if (!cell.IsUsed)
                    {
                        bool free = true;
                        for (int i = x; i < x + itemSizeX; i++)
                        {
                            for (int j = y; j < y + itemSizeY; j++)
                            {
                                if (cells[i, j].IsUsed)
                                {
                                    free = false;
                                    break;
                                }
                            }
                            if (!free)
                                break;
                        }

                        if (free)
                        {
                            AddItemToCells(x, y, itemSizeX, itemSizeY, stackable, itemName, currentStackSize, maxStackSize, iconMetadata);
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        private void AddItemToCells(int x, int y, int itemSizeX, int itemSizeY, bool stackable, string itemName, int stackSize, int maxStackSize, string iconMetadata)
        {
            if (!iconMetadata.EndsWith(".dds"))
                iconMetadata = "";

            for (int i = x; i < x + itemSizeX; i++)
            {
                for (int j = y; j < y + itemSizeY; j++)
                {
                    cells[i, j].SetItem(itemName, stackable, stackSize, maxStackSize, itemSizeX, itemSizeY, iconMetadata);
                }
            }
        }

        public override void OnClose()
        {
            MouseHook.MouseDown -= onMouseDown;
        }


        private Dictionary<string, ImageCache> ImagesCache = new Dictionary<string, ImageCache>();

        private ImageCache GetImage(string metadata)
        {
            ImageCache result;

            if (!ImagesCache.TryGetValue(metadata, out result))
            {
                result = DownloadImage(metadata);
                ImagesCache.Add(metadata, result);
            }

            return result;
        }

        //Images from site:
        //http://webcdn.pathofexile.com/image/Art/2DItems/Currency/CurrencyRerollRare.png
        private ImageCache DownloadImage(string metadata)
        {
            //Metadata will be always contains (ends with) ".dds" keyword. Check AddItemToCells.

            metadata = metadata.Replace(".dds", ".png");
            var url = "http://webcdn.pathofexile.com/image/" + metadata;
            
            var filePath = LocalPluginDirectory + "/resources/" + metadata;


            ImageCache img = new ImageCache()
            {
                FilePath = filePath,
                Url = url
            };


            try
            {
                if (File.Exists(img.FilePath))
                {
                    img.bIsDownloaded = true;
                    return img;
                }

                var settingsDirName = Path.GetDirectoryName(img.FilePath);
                if (!Directory.Exists(settingsDirName))
                    Directory.CreateDirectory(settingsDirName);

                WebClient webClient = new WebClient();
                webClient.DownloadDataAsync(new Uri(img.Url), img.FilePath);
                webClient.DownloadDataCompleted += img.OnGetDownloadedStringCompleted;
            }
            catch
            {
                LogError("Error processing: Url: " + img.Url + ", Path: " + img.FilePath, 4);
            }
            return img;
        }

        private class ImageCache
        {
            public bool bIsDownloaded;
            public string Url;
            public string FilePath;

            public void OnGetDownloadedStringCompleted(object sender, DownloadDataCompletedEventArgs e)
            {
                if (e.Error == null)
                {
                    Bitmap flaskImg;
                    using (var ms = new MemoryStream(e.Result))
                    {
                        flaskImg = new Bitmap(ms);
                    }

                    if (FilePath.Contains("Flasks"))//Cut 1/3 of flask image
                    {
                        flaskImg = CropImage(flaskImg, new System.Drawing.Rectangle(0, 0, flaskImg.Width / 3, flaskImg.Height));
                    }

                    flaskImg.Save(FilePath, System.Drawing.Imaging.ImageFormat.Png);

                    bIsDownloaded = true;//Due to async processing this must be in the last line
                }
            }


            //from http://stackoverflow.com/questions/9484935/how-to-cut-a-part-of-image-in-c-sharp
            public Bitmap CropImage(Bitmap source, System.Drawing.Rectangle section)
            {
                return source.Clone(section, source.PixelFormat);
            }
        }
    }
}