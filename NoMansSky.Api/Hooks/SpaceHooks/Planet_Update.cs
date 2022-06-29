using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GalaxyMapHooks
{
    public unsafe class Planet_Update : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long planetAddress, long a2, long a3);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public static HashSet<long> planetAddresses = new HashSet<long>();

        #endregion

        
        public string HookName => "On Planet Updated";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 53 48 81 EC ? ? ? ? 48 89 78 18";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        const int offsetToBaseAddress = 0x60;
        private long CodeToExecute(long planetAddress, long a2, long a3)
        {
            // nothing here yet. Will look into more later.

            if (!planetAddresses.Contains(planetAddress + offsetToBaseAddress))
            {
                planetAddresses.Add(planetAddress + offsetToBaseAddress);
            }

            var result = Hook.OriginalFunction(planetAddress, a2, a3);

            return result;
        }
    }
}
