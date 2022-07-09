using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    internal unsafe class DefaultSaveDataDestructor : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        public string HookName => "DefaultSaveDataDestructor";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 4C 24 ? 53 56 57 48 83 EC 30 48 C7 44 24 ? ? ? ? ? 48 8B F9 48 81 C1 ? ? ? ? 48 89 4C 24 ? 4C 8D 0D ? ? ? ? BA ? ? ? ? 41 B8 ? ? ? ? E8 ? ? ? ? 90 33 F6 ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }

        internal static long address;
        private long CodeToExecute(long address)
        {
            DefaultSaveDataDestructor.address = address;
            Console.WriteLine($"a1: {address}");
            Console.WriteLine($"a1: {address.ToHex()}");

            /*var memory = new MemoryManager();
            var saveData = memory.GetValue<GcDefaultSaveData>(address);

            File.WriteAllText(@"C:\Users\thoma\Desktop\NmsAPI Test\Default Save Data Dump.txt", saveData.AsString());*/


            var result = Hook.OriginalFunction(address);
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"result: {result.ToHex()}");
            return result;



            return 0;
        }
    }
}
