using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class OnPlayerHealthValueChanged : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, int a2);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.OnHealthChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "ChangePlayerHealth";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 89 5C 24 ? 48 89 74 24 ? 57 48 83 EC 20 33 FF B8";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, int a2)
        {
            amountChangedParam.value = a2;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            var result = Hook.OriginalFunction(a1, amountChangedParam.value);
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return result;
        }
    }
}
