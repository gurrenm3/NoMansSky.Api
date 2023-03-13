using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Player
{
    internal unsafe class LoadDefaultStateData : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(char* a1, long a2, char a3);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        public string HookName => "Load Default Save Data";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "40 55 56 57 41 54 41 55 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 45 8B F8 48 8B DA 4C 8B E1 41 8B C0 83 E0 04";
            var address = new Signature(pattern).Scan();
            Function = _hooks.CreateFunction<HookDelegate>(address);

            logger.WriteLine($"DefaultSaveData address: {address.ToHex()}");
            //Hook = Function.Hook(CodeToExecute).Activate();
        }

        internal static long address;
        private long CodeToExecute(char* a1, long a2, char a3)
        {

            var result = Hook.OriginalFunction(a1, a2, a3);

            logger.WriteLine($"Load DefaultSaveData:  A1: {((long)a1).ToHex()} | A2: {a2.ToHex()} | A3: {a3} | Result: {result} | Result(Hex): {result.ToHex()}");

            return 9;
        }
    }
}
