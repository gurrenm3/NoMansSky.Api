using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    internal unsafe class LoadGlobals : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, long a2, char* mbinName, long a4, long addressToLoadedMbin);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        public string HookName => "Load Globals";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "0F 10 05 ? ? ? ? 48 8B C2 F2 0F 10 0D ? ? ? ? 0F 11 02 F2 0F 11 4A ? C3 ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, long a2, char* mbinName, long a4, long addressToLoadedMbin)
        {
            var result = Hook.OriginalFunction(a1, a2, mbinName, a4, addressToLoadedMbin);

            var actualName = StringUtils.ToString(mbinName);
            if (!string.IsNullOrEmpty(actualName) && addressToLoadedMbin > 0)
            {
                var mbin = new MBin(actualName, addressToLoadedMbin);
                IGame.Instance.MBinManager.RegisterMBin(mbin);
            }

            return result;
        }
    }
}
