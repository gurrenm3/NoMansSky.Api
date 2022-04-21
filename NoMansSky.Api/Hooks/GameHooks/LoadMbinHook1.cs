using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{
    public unsafe class LoadMbinHook1 : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(char* mbinName, char* a2, long a3, long a4, long a5, long a6, long a7, long a8, long a9, long a10);

        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }
        public static string currentMbin;

        public string HookName => "Load MBIN";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 4C 24 ? 57 41 54 41 55 41 56 41 57 48 83 EC 30 48 C7 44 24 ? ? ? ? ? 48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 48 8B F2";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        
        private long CodeToExecute(char* mbinName, char* a2, long a3, long a4, long a5, long a6, long a7, long a8, long a9, long a10)
        {
            long result = 0;

            var name = Strings.ToString(a2);
            currentMbin = name;

            result = Hook.OriginalFunction(mbinName, a2, a3, a4, a5, a6, a7, a8, a9, a10);

            var mbinAddress = *((long*)mbinName + 13);
            var mbin = new MBin()
            {
                Name = name,
                Address = mbinAddress
            };
            Game.Instance.MBinManager.OnMBinLoaded.Invoke(mbin);
            return result;
        }
    }
}
