using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{
    internal unsafe class GetGcGalaxyMap : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long gcGalaxyMapAddress);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        

        public string HookName => "Some function to get GcGalaxyMap";
        private IModLogger logger;
        private long address = 0;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 5C 24 ? 57 48 83 EC 40 48 8B F9 C7";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long gcGalaxyMapAddress)
        {
            var result = Hook.OriginalFunction(gcGalaxyMapAddress);

            if (address != 0)
                return result;

            address = gcGalaxyMapAddress;

            var mbin = new MBin() { Name = "GcGalaxyMap", Address = gcGalaxyMapAddress };
            IGame.Instance.MBinManager.OnMBinLoaded.Invoke(mbin);

            return result;
        }
    }
}
