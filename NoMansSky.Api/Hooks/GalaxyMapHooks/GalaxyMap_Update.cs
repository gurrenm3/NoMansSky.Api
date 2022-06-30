using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GalaxyMapHooks
{
    public unsafe class GalaxyMap_Update : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long galaxyMapAddress, float deltaTime);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        /// <summary>
        /// The mod event hook for this game hook.
        /// </summary>
        public static IModEventHook ModEventHook = new SharedModEventHook();

        

        public string HookName => "GalaxyMap.Update";
        private IModLogger logger;
        private GalaxyMap galaxyMap;
        private int updateCount = 0;
        private int lastUpdateCount = 0;
        private IGame game;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            game = IGame.Instance;
            galaxyMap = (GalaxyMap)game.GalaxyMap;
            logger = _logger;

            // string pattern = "48 8B 49 10 E9 ? ? ? ? " // has duplicates. Use it to find pattern below if issues.
            string pattern = "48 8B 49 10 E9 67 ? ? ? ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();




            /*game.GameLoop.OnUpdate.Prefix += () =>
            {

            };

            game.GameLoop.OnUpdate.Postfix += () =>
            {
                // these should log 1:1 otherwise I need to account for different firing amounts.
                logger.WriteLine("Game.Update");
                if (!galaxyMap.IsOpened)
                    return;

                if (updateCount > lastUpdateCount)
                {
                    lastUpdateCount++;
                }
                else if (updateCount == lastUpdateCount) // it didn't update this frame. It's closed or we're warping
                {
                    galaxyMap.IsOpened = false;
                    updateCount = 0;
                    lastUpdateCount = 0;
                }
            };*/
        }

        private long CodeToExecute(long galaxyMapAddress, float deltaTime)
        {
            logger.WriteLine("GalaxyMap.Update");

            updateCount++;
            galaxyMap.IsOpened = true;
            ModEventHook.Prefix.Invoke();

            var result = Hook.OriginalFunction(galaxyMapAddress, deltaTime);

            ModEventHook.Postfix.Invoke();

            return result;
        }
    }
}
