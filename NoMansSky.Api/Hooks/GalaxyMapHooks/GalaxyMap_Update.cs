using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
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
        private bool ranUpdateFromHere = false; // reflects whether game.update was manually invoked here.
        private Game game;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            game = (Game)IGame.Instance;
            galaxyMap = (GalaxyMap)game.GalaxyMap;
            logger = _logger;

            // string pattern = "48 8B 49 10 E9 ? ? ? ? " // has duplicates. Use it to find pattern below if issues.
            string pattern = "48 8B 49 10 E9 67 ? ? ? ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            // Handles GalaxyMap.OnClosed
            game.GameLoop.OnUpdate.Prefix += () =>
            {
                if (!ranUpdateFromHere && galaxyMap.IsOpened)
                {
                    galaxyMap.IsOpened = false;
                    galaxyMap.OnClosed.Invoke();
                }
            };
        }

        private long CodeToExecute(long galaxyMapAddress, float deltaTime)
        {
            // we're loading into a save file.
            if (!game.IsInGame)
                return Hook.OriginalFunction(galaxyMapAddress, deltaTime);

            // this is the first frame it's opened
            if (!galaxyMap.IsOpened)
            {
                galaxyMap.IsOpened = true;
                galaxyMap.OnOpened.Invoke();
            }

            // have to manually call update loop because it doesn't run while GalaxyMap is opened.
            ranUpdateFromHere = true;
            game.GameLoop.OnUpdate.Prefix.Invoke();
            ModEventHook.Prefix.Invoke();

            var result = Hook.OriginalFunction(galaxyMapAddress, deltaTime);

            ModEventHook.Postfix.Invoke();
            game.GameLoop.OnUpdate.Postfix.Invoke();
            ranUpdateFromHere = false;

            return result;
        }
    }
}
