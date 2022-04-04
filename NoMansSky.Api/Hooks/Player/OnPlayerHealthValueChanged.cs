using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class OnPlayerHealthValueChanged : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, int a2);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static bool isLoadingProfile = false;

        public string HookName => "ChangePlayerHealth";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 89 5C 24 ? 48 89 74 24 ? 57 48 83 EC 20 33 FF B8";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, int a2)
        {
            bool isNegative = a2 < 0;
            if (isNegative)
                a2 = Math.Abs(a2);

            var moddableValue = new EventParams<int>(a2);
            Game.Instance.Player.OnHealthChanged.Prefix.Invoke(moddableValue);

            if (isNegative)
                moddableValue.value *= -1;

            var result = Hook.OriginalFunction(a1, moddableValue.value);
            Game.Instance.Player.OnHealthChanged.Postfix.Invoke(moddableValue.value);

            return result;
        }
    }
}
