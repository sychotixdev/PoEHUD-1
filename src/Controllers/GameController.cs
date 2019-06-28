using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PoeHUD.EntitiesCache;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud;
using PoeHUD.Hud.DebugPlugin;
using PoeHUD.Hud.Settings;
using PoeHUD.Models;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Controllers
{
    public class GameController
    {
        public static GameController Instance;
        public readonly Runner CoroutineRunner;
        public readonly Runner CoroutineRunnerParallel;

        //This need for pause coroutines from plugins when it disabled
        public readonly Dictionary<string, SettingsBase> pluginsSettings = new Dictionary<string, SettingsBase>();
        public Action Clear = delegate { };
        public ConcurrentDictionary<string, float> DebugInformation = new ConcurrentDictionary<string, float>();
        public bool IsForeGroundLast;
        public PerformanceSettings Performance;
        public Action Render = delegate { };
        private readonly StashTabController StashController;

        public GameController(Memory memory)
        {
            Instance = this;
            Memory = memory;
            Game = new TheGame(memory);
            GameStateController = new GameStateController(memory, Game);
            CoroutineRunner = new Runner("Main Coroutine");
            CoroutineRunnerParallel = new Runner("Parallel Coroutine");
            Window = new GameWindow(memory.Process);
            Cache = new Cache();
            Files = new FsController(memory);
            Area = new AreaController(this);
            StashController = new StashTabController();
            InGame = InGameReal;
            IsForeGroundCache = WinApi.IsForegroundWindow(Window.Process.MainWindowHandle);
            MainTimer = Stopwatch.StartNew();
        }

        public GameStateController GameStateController { get; }
        public GameWindow Window { get; }
        public TheGame Game { get; }
        public AreaController Area { get; }
        public Cache Cache { get; }
        public Memory Memory { get; }
        public Stopwatch MainTimer { get; }
        public bool InGame { get; private set; }
        public bool IsLoading { get; private set; }
        public bool InGameReal => Game.InGameState.InGame;
        public bool AutoResume { get; set; }
        public FsController Files { get; }
        public bool IsForeGroundCache { get; private set; }
        public long RenderCount { get; private set; }
        public static event Action<bool> eIsForegroundChanged = delegate { };

        public void WhileLoop()
        {
            Task.Run(ParallelCoroutineRunner);
            DebugInformation["FpsLoop"] = 0;
            DebugInformation["FpsRender"] = 0;
            DebugInformation["FpsCoroutine"] = 0;
            DebugInformation["ElapsedMilliseconds"] = 0;
            var sw = Stopwatch.StartNew();
            float nextRenderTick = sw.ElapsedMilliseconds;
            var tickEverySecond = sw.ElapsedMilliseconds;
            var skipTicksRender = 0f;
            var fpsLoop = 0;
            var fpsRender = 0;
            var fpsCoroutine = 0;
            var updateRate = 1f / 60f;
            float loopLimit = 1;
            var updateAreaLimit = 100;
            var updateEntityLimit = 50;
            var updateStashTabs = 500;
            var updateIngameState = 100;
            var deltaError = 500;

            //Pause?resumt coroutines in plugins
            foreach (var setting in pluginsSettings)
            {
                setting.Value.Enable.OnValueChanged += () =>
                {
                    var coroutines = CoroutineRunner.Coroutines.Where(x => x.Owner == setting.Key)
                        .Concat(CoroutineRunnerParallel.Coroutines.Where(x => x.Owner == setting.Key)).ToList();

                    foreach (var coroutine in coroutines)
                    {
                        if (setting.Value.Enable)
                        {
                            if (coroutine.AutoResume)
                                coroutine.Resume();
                        }
                        else
                            coroutine.Pause();
                    }
                };
            }

            void MainCoroutineAction()
            {
                var coroutines = CoroutineRunner.Coroutines.Concat(CoroutineRunnerParallel.Coroutines).ToList();

                if (!InGame || !IsForeGroundCache || IsLoading)
                {
                    Clear();

                    foreach (var cor in coroutines)
                    {
                        cor.Pause();
                    }

                    AutoResume = true;
                }
                else
                {
                    if (AutoResume)
                    {
                        foreach (var coroutine in coroutines)
                        {
                            if (pluginsSettings.TryGetValue(coroutine.Owner, out var result))
                            {
                                if (result.Enable && coroutine.AutoResume)
                                    coroutine.Resume();
                                else
                                    continue;
                            }

                            if (coroutine.AutoResume)
                                coroutine.Resume();
                        }

                        AutoResume = false;
                    }

                    foreach (var coroutine in coroutines)
                    {
                        if (pluginsSettings.TryGetValue(coroutine.Owner, out var result) && !result.Enable)
                            coroutine.Pause();
                    }
                }
            }

            //Main work for coroutines logic when you not in game
            var updateCoroutine = new Coroutine(MainCoroutineAction, 250, nameof(GameController), "$#Main#$") {Priority = CoroutinePriority.Critical};

            //Coroutine for update area
            var updateArea = new Coroutine(() => { Area.RefreshState(); }, updateAreaLimit, nameof(GameController), "Update area")
                {Priority = CoroutinePriority.High};

            //Coroutine for update entity list
            var updateEntity =
                new Coroutine(() => { EntitiesAreaCache.Current.UpdateCache(); }, updateEntityLimit, nameof(GameController), "Update Entity")
                    {Priority = CoroutinePriority.High};

            var checkTabs =
                new Coroutine(() => { StashController.CheckStashTabsLoop(); }, updateStashTabs, nameof(StashTabController), "Stash Tab Controller")
                    {Priority = CoroutinePriority.Normal};

            //
            //Control cache for game status
            var updateGameState = new Coroutine(() =>
            {
                InGame = InGameReal;
                IsForeGroundCache = Performance.AlwaysForeground || WinApi.IsForegroundWindow(Window.Process.MainWindowHandle);
                Cache.ForceUpdateWindowCache();
                IsLoading = Game.IsGameLoading;
            }, updateIngameState, nameof(GameController), "Update Game State") {Priority = CoroutinePriority.Critical}.Run();

            //Update coroutine setting when change settings in menu
            if (Performance != null)
            {
                loopLimit = Performance.LoopLimit;
                skipTicksRender = 1000f / Performance.RenderLimit;
                Cache.Enable = Performance.Cache;
                updateAreaLimit = Performance.UpdateAreaLimit;
                updateEntityLimit = Performance.UpdateEntityDataLimit;
                updateIngameState = Performance.UpdateIngemeStateLimit;

                Performance.UpdateEntityDataLimit.OnValueChanged += () =>
                {
                    CoroutineRunner.Coroutines.Concat(CoroutineRunnerParallel.Coroutines).FirstOrDefault(x => x.Name == "Update Entity")
                        ?.UpdateCondtion(new WaitTime(1000 / Performance.UpdateEntityDataLimit.Value));
                };

                Performance.RenderLimit.OnValueChanged += () => { skipTicksRender = 1000f / Performance.RenderLimit; };
                Performance.LoopLimit.OnValueChanged += () => { loopLimit = 300 + Performance.LoopLimit; };

                Performance.UpdateAreaLimit.OnValueChanged += () =>
                {
                    CoroutineRunner.Coroutines.Concat(CoroutineRunnerParallel.Coroutines).FirstOrDefault(x => x.Name == "Update Entity")
                        ?.UpdateCondtion(new WaitTime(Performance.UpdateAreaLimit));
                };

                Performance.UpdateIngemeStateLimit.OnValueChanged += () =>
                {
                    CoroutineRunner.Coroutines.Concat(CoroutineRunnerParallel.Coroutines).FirstOrDefault(x => x.Name == "Update Entity")
                        ?.UpdateCondtion(new WaitTime(Performance.UpdateIngemeStateLimit));
                };

                Performance.Cache.OnValueChanged += () => { Cache.Enable = Performance.Cache; };

                Performance.DpsUpdateTime.OnValueChanged += () =>
                {
                    CoroutineRunner.Coroutines.Concat(CoroutineRunnerParallel.Coroutines).FirstOrDefault(x => x.Name == "Calculate DPS")
                        ?.UpdateCondtion(new WaitTime(Performance.DpsUpdateTime));
                };
            }

            updateArea.AutoRestart(CoroutineRunner).Run();

            //Update entity list in another thread give more smoothness for ui but need more nullable check
            if (Performance?.ParallelEntityUpdate)

                //Sometimes parallel maybe unstable need testing
                updateEntity.AutoRestart(CoroutineRunnerParallel).RunParallel();
            else
                updateEntity.AutoRestart(CoroutineRunner).Run();

            sw.Restart();
            updateCoroutine.Run();
            checkTabs.Run();

            while (true)
            {
                if (!InGame)
                    Thread.Sleep(50);

                var startFrameTime = sw.Elapsed.TotalMilliseconds;

                for (var j = 0; j < CoroutineRunner.RunPerLoopIter; j++)
                {
                    if (CoroutineRunner.IsRunning)
                    {
                        fpsCoroutine++;

                        try
                        {
                            CoroutineRunner.Update();
                        }
                        catch (Exception e)
                        {
                            DebugPlugin.LogMsg($"Coroutine error: {e.Message}", 1);
                        }
                    }
                }

                if (IsForeGroundLast != IsForeGroundCache)
                {
                    IsForeGroundLast = IsForeGroundCache;
                    eIsForegroundChanged(IsForeGroundCache);
                }

                if (sw.Elapsed.TotalMilliseconds >= nextRenderTick && InGame && IsForeGroundCache && !IsLoading)
                {
                    Render();
                    nextRenderTick += skipTicksRender;
                    fpsRender++;
                    RenderCount++;
                    DebugInformation["DeltaRender"] = (float) (sw.Elapsed.TotalMilliseconds - startFrameTime);
                }

                if (sw.ElapsedMilliseconds >= tickEverySecond)
                {
                    DebugInformation["FpsLoop"] = fpsLoop;
                    DebugInformation["FpsRender"] = fpsRender;
                    DebugInformation["FpsCoroutine"] = fpsCoroutine;
                    DebugInformation["Looplimit"] = loopLimit;
                    DebugInformation["ElapsedSeconds"] = sw.Elapsed.Seconds;
                    DebugInformation["FpsRenderCount"] = RenderCount;
                    fpsLoop = 0;
                    fpsRender = 0;
                    fpsCoroutine = 0;
                    tickEverySecond += 1000;

                    if (nextRenderTick - sw.ElapsedMilliseconds > deltaError || nextRenderTick - sw.ElapsedMilliseconds < deltaError)
                        nextRenderTick = sw.ElapsedMilliseconds;

                    //Autorestart coroutines in main thread
                    foreach (var autorestartCoroutine in CoroutineRunner.AutorestartCoroutines)
                    {
                        if (!CoroutineRunner.HasName(autorestartCoroutine.Name))
                            autorestartCoroutine.GetCopy().Run();
                    }

                    //Autorestart coroutines in another thread
                    foreach (var autorestartCoroutine in CoroutineRunnerParallel.AutorestartCoroutines)
                    {
                        if (!CoroutineRunnerParallel.HasName(autorestartCoroutine.Name))
                            autorestartCoroutine.GetCopy().RunParallel();
                    }

                    Game.RefreshTheGameState();
                }

                fpsLoop++;
                DebugInformation["ElapsedMilliseconds"] = sw.ElapsedMilliseconds;
                DebugInformation["DeltaTimeMs"] = (float) (sw.Elapsed.TotalMilliseconds - startFrameTime);

                if (fpsLoop >= loopLimit)
                    Thread.Sleep(1);
            }
        }

        //Thread for parallel coroutines runner
        private async Task ParallelCoroutineRunner()
        {
            var parallelFps = 0;

            while (true)
            {
                if (CoroutineRunnerParallel.IsRunning)
                {
                    try
                    {
                        CoroutineRunnerParallel.Update();
                    }
                    catch (Exception e)
                    {
                        DebugPlugin.LogMsg($"{e.Message}", 100);
                    }
                }
                else
                    await Task.Delay(100);

                parallelFps++;

                if (parallelFps >= Performance.ParallelCoroutineLimit)
                {
                    await Task.Delay(1);
                    DebugInformation["Parallel Coroutine FPS"] = parallelFps;
                    parallelFps = 0;
                }
            }
        }
    }
}
