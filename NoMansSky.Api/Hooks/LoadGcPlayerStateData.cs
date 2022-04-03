using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class LoadGcPlayerStateData : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //public delegate long HookDelegate(long self, long a2, long a3, long a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, void* a14, void* a15);
        public delegate long HookDelegate(long a1, long a2, int a3);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "LoadGcPlayerStateData";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            //string pattern = "40 55 57 41 54 41 56 41 57 48 8B EC 48 83 EC 40 48 C7 45 ? ? ? ? ? 48 89 5C 24 ? 48 89 B4 24 ? ? ? ? 41 0F";
            string pattern = "48 89 5C 24 ? 56 48 83 EC 20 48 B8 2E ? ? ? ? ? ? ? 41 0F B6 F0 48 8B DA 48 39 41 48 0F 85 ? ? ? ? 48 89 7C 24 ? 48 8B 39 48 85 FF 0F 84 ? ? ? ? 48 B8 ? ? ? ? ? ? ? ? 4C 8D 4C 24 ? 4C 8D 44 24 ? 48";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        //private long CodeToExecute(long self, long a2, long a3, long a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, void* a14, void* a15)
        private long CodeToExecute(long a1, long a2, int a3)
        {
            logger.WriteLine("LoadGcPlayerStateData - Prefix");
            //var result = Hook.OriginalFunction(self, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15);
            var result = Hook.OriginalFunction(a1, a2, a3);

            /*var inventory = ((long*)(self))[56];
            var slot1 = ((long*)inventory)[0];
            var element = ((GcInventoryElement*)slot1);

            logger.WriteLine(element->amount);*/

            logger.WriteLine("LoadGcPlayerStateData - Postfix");

            return result;
        }
    }
}
