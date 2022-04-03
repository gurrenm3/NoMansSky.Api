using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class PossibleSelectProfile : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long self);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "OnPlayerProfileSelected";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "40 55 56 57 41 54 41 55 41 56 41 57 48 8B EC 48 83 EC 50 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 4C 8B E9 48";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long self)
        {
            var result = Hook.OriginalFunction(self);
            Game.Instance.OnProfileSelected.InvokeAll();
            return result;
        }
    }
}
