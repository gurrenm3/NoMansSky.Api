using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.InventoryHooks
{
    internal unsafe class SellItemHook : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long self, GcInventoryElement* someAddress, GcInventoryElement* someAddr2);

        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }

        public string HookName => "OnItemSold";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 4C 89 48 20 48 89 48 08 55 56 57 41 54 41 55 41 56 41 57 48 83";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }

        // TODO
        private long CodeToExecute(long self, GcInventoryElement* a2, GcInventoryElement* a3)
        {
            var item = a3;

            var result = Hook.OriginalFunction(self, a2, a3);

            item = a3;

            //var ptr = (IntPtr)item->id;

            //logger.WriteLine(name);

            return result;
        }
    }
}
