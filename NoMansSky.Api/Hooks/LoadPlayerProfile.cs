using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class LoadPlayerProfile : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static bool isLoadingProfile = false;

        public string HookName => "OnPlayerProfileLoaded";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            //string patternOld = "40 55 56 57 41 54 41 55 41 56 41 57 48 8B EC 48 83 EC 50 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 4C 8B E9 48";
            //string patternOld2 = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";
            string pattern = "48 89 4C 24 ? 55 53 56 57 41 54 41 55 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 4C 8B E1 48";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1)
        {
            LoadGcPlayerStateData.loopCounter = 0;
            isLoadingProfile = true;
            var result = Hook.OriginalFunction(a1);
            isLoadingProfile = false;

            Game.Instance.OnProfileSelected.Invoke();
            return result;
        }
    }
}
