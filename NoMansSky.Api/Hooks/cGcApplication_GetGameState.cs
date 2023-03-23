using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Game
{
    public unsafe class cGcApplication_GetGameState : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        public static long GcApplicationPtr { get; private set; }
        public static long GcGameStatePtr { get; private set; }

        public string HookName => "cGcApplication_GetGameState";
        private IModLogger logger;
        private bool first = true;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "48 8B 05 E1 52 7D 04 48 05 D0 0F 00 00 C3";
            long address = new Signature(pattern).Scan();

            logger.WriteLine(address);
            logger.WriteLine(address.ToHex());
            //long address = 0x14019B530;

            Function = _hooks.CreateFunction<HookDelegate>(address);
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long cgcApplication)
        {
            if (!first)
                return Hook.OriginalFunction(cgcApplication);

            long gameStateAddress = Hook.OriginalFunction(cgcApplication);

            GcApplicationPtr = cgcApplication;
            GcGameStatePtr = gameStateAddress;

            logger.WriteLine("Acquired GcApplicationPtr");
            logger.WriteLine("Acquired GcGameStatePtr");

            first = false;

            return gameStateAddress;
        }
    }
}