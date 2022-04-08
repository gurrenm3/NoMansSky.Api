using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class OnPlayerShieldValueChanged : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, float a2, int a3, long* a4, long* a5, long a6, float** a7);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<float> ModEventHook => Game.Instance.Player.OnShieldChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "ChangeShieldValue";
        private EventParam<float> amountChangedParam = new EventParam<float>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 8B C4 4C 89 48 20 44 89 40 18 55 56 57 41 54 41 55 41 56 41 57 48 8D";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, float a2, int a3, long* a4, long* a5, long a6, float** a7)
        {
            amountChangedParam.value = a2;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            var result = Hook.OriginalFunction(a1, amountChangedParam.value, a3, a4, a5, a6, a7);
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return result;
        }
    }
}
