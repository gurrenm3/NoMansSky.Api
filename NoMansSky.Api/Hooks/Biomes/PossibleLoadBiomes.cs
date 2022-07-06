using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Biome
{
    internal unsafe class PossibleLoadBiomes : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        internal static bool isLoadingBiomes = false;

        public string HookName => "SomeBiomeFunc1";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            //string pattern = "48 89 5C 24 ? 48 8B 1A 4C 8B D1";
            string pattern = "48 89 4C 24 ? 55 53 56 57 41 54 41 55 41 56 41 57 48 8B EC 48 83 EC 78 48 C7 45 ? ? ? ? ? 48 8B D9 ";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            //Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1)
        {
            isLoadingBiomes = true;

            Console.WriteLine("isloading biomes");
            var result = Hook.OriginalFunction(a1);
            Console.WriteLine("done loading biomes");

            isLoadingBiomes = false;
            return result;
        }
    }
}
