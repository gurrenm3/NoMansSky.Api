using NoMansSky.Api.Hooks.Game;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Space
{
    internal unsafe class GenerateSolarSystem : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        public string HookName => "GenerateSolarSystem";
        private IModLogger logger;
        private bool firstRun = true;
        private Api.Game game;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            game = (Api.Game)IGame.Instance;

            string pattern = "48 8B C4 55 41 54 41 55 41 56 41 57 48 8D 68 C8 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 58 10 48 89 70 18 48 89 78 20 48";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate(); // hook unused for now

            //game.OnWarpFinished += () => firstRun = true;
        }

        private long CodeToExecute(long a1)
        {
            var result = Hook.OriginalFunction(a1);

            return result;
        }
    }
}
