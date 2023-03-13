using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Inventory
{
    internal unsafe class Inventory_SomeFunction : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long* self, long* a2, long* a3);

        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }

        public string HookName => "Inventory_SomeFunction";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 41 54 41 56 41 57 48 81 EC ? ? ? ? 48 C7 40 ? ? ? ? ? 48 89 58 10 48 89 70 18 48 89 78 20 4D 8B F8 48 8B DA 4C 8B F1 4C 8B 09 49 2B D1 49 BA ? ? ? ? ? ? ? ? 49 8B C2 48 F7 EA 48 8B F2 48 C1 FE 03 48 8B C6 48 C1 E8 3F 48 03 F0 48 8B 49 08 49 2B C9 49 8B C2 48 F7 E9 48 C1 FA 03 48 8B C2 48 C1 E8 3F 48 03 D0 49 B8 ? ? ? ? ? ? ? ? 49 3B D0 0F 84 ? ? ? ? 4C 8D 62 01 49 8B 4E 10 49 2B C9";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }

        // TODO
        private long CodeToExecute(long* self, long* a2, long* a3)
        {
            logger.WriteLine($"Test 1: {(long)(a2 - *self) / 0x30}");
            logger.WriteLine($"Test 2: {(long)(a2 - *self) / 48}");
            logger.WriteLine($"Test 3: {(a2 - self) / 48}");
            logger.WriteLine("---------------------------------");


            var result = Hook.OriginalFunction(self, a2, a3);


            return result;
        }
    }
}
