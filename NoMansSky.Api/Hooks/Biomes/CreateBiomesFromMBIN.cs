using libMBIN.NMS.GameComponents;
using NoMansSky.Api.Hooks.Biome;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    internal unsafe class CreateBiomesFromMBIN : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, char* mbinName, long a3);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        public string HookName => "CreateBiomesFromMBIN";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 56 57 41 54 41 56 41 57 48 81 EC ? ? ? ? 48 C7 44 24 ? ? ? ? ? 48 89 58 18 48 89 68 20 45 0F B6 F8 48 8B FA 48 8B E9 40 32 F6 40 88 74 24 ? 45 33 F6 48 85 D2 74 62 44 38 32 74 5D 41 8B F6 48 8D 5C 24 ? 32 D2 0F 1F 40 00 81 FE ? ? ? ? 7D 3F 0F B6 07";
            
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }



        private long CodeToExecute(long a1, char* mbinName, long a3)
        {
            /*if (!PossibleLoadBiomes.isLoadingBiomes)
                return Hook.OriginalFunction(a1, mbinName, a3);*/

            var addressToObject = Hook.OriginalFunction(a1, mbinName, a3);

            Console.WriteLine("---------------------------");
            var nameStr = Strings.ToString(mbinName);
            if (!string.IsNullOrEmpty(nameStr))
            {
                Console.WriteLine(nameStr);
            }

            Console.WriteLine($"a1: {a1.ToHex()} | a2: {((long)mbinName).ToHex()} | a3: {a3} | result {addressToObject.ToHex()}");

            return addressToObject;
        }
    }
}
