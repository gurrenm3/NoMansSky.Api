using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class Game_Update : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate double HookDelegate();

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook => Game.Instance.OnUpdate;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "Game_Update";
        private IModLogger logger;
        private TimeHooked time;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "40 53 48 83 EC 20 48 8D 4C 24 ? FF 15 ? ? ? ? 48 8B 5C 24 ? 48 8D 4C 24 ? FF 15 ? ? ? ? F2";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            time = Game.Instance.Time as TimeHooked;
        }

        private double CodeToExecute()
        {
            ModEventHook.Prefix.Invoke();

            double elapsedTime = Hook.OriginalFunction();
            time.Update(elapsedTime);

            ModEventHook.Postfix.Invoke();

            return elapsedTime;
        }
    }
}
