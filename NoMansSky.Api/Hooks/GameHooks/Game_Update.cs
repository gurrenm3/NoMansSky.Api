using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{
    internal unsafe class Game_Update : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void HookDelegate(long a1, double a2);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook => IGame.Instance.GameLoop.OnUpdate;
        public string HookName => "Game_Update";
        private HookedTime time => IGame.Instance.GameLoop.Time as HookedTime;
        private IModLogger logger;
        private Stopwatch stopwatch;


        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            // Old pattern. Doesn't run on splash screen when game is starting. Replaced with new one below.
            //string pattern = "40 53 48 83 EC 20 48 8D 4C 24 ? FF 15 ? ? ? ? 48 8B 5C 24 ? 48 8D 4C 24 ? FF 15 ? ? ? ? F2";
            string pattern = "41 56 48 83 EC 60 48 8B 41 58";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private void CodeToExecute(long a1, double a2)
        {
            if (stopwatch == null)
            {
                stopwatch = new Stopwatch();
                stopwatch.Start();
            }

            ModEventHook.Prefix.Invoke();

            Hook.OriginalFunction(a1, a2);

            var elapsedTime = stopwatch.Elapsed.TotalMilliseconds;
            time.Update(elapsedTime);

            ModEventHook.Postfix.Invoke();
        }
    }
}
