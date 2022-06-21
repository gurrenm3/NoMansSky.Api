using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    public unsafe class LoadMbinHook2 : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void HookDelegate(long a1, long a2, int a3, int a4);

        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }

        public string HookName => "Load MBIN2";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 51 08 44 89 41 10 44 89 49 14 C3 ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }


        private void CodeToExecute(long a1, long a2, int a3, int a4)
        {
            if (LoadMbinHook1.currentMbin == "cGcRefinerUnitComponentData")
            {
                logger.WriteLine($"LoadMBIN2: a2 {a2}");
                logger.WriteLine($"LoadMBIN2: a2 {a2.ToString("X")}");
            }
            Hook.OriginalFunction(a1, a2, a3, a4);
        }
    }
}
