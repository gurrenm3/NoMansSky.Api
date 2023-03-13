using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GalaxyMap
{
    internal unsafe class Warp_Update : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate double HookDelegate(long a1, float deltaTime);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        /// <summary>
        /// The mod event tied to this update loop
        /// </summary>
        public static IModEventHook ModEventHook = new SharedModEventHook();

        #endregion

        
        public string HookName => "On Warp Updated";
        private IModLogger logger;
        private bool firstRun = true;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            logger.WriteLine($"{HookName} is temporarily disabled...");
            return;

            string pattern = "48 8B C4 F3 0F 11 48 ? 55 56 57 41 54 41 55 41 56 41 57 48 8D A8 ? ? ? ? 48 81 EC ? ? ? ? 48 C7 85 ? ? ? ? ? ? ? ? 48 89 58 08 0F 29 70 B8 44";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            IGame.Instance.OnWarpFinished += () => firstRun = true;
        }

        private double CodeToExecute(long a1, float deltaTime)
        {
            // it's just loading in from the save file.
            if (!IGame.Instance.IsInGame)
                return Hook.OriginalFunction(a1, deltaTime);

            if (firstRun)
            {
                IGame.Instance.OnWarpStarted.Invoke();
                firstRun = false;
            }

            ModEventHook.Prefix.Invoke();
            var result = Hook.OriginalFunction(a1, deltaTime);
            ModEventHook.Postfix.Invoke();

            return result;
        }
    }
}
