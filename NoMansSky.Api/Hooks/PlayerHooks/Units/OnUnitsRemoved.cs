using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class OnUnitsRemoved : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc1(int amountLost);

        public OnChangedFunc1 pattern1Func;

        // this needs to be static due to how the API auto-registers hooks
        private IReverseWrapper<OnChangedFunc1> pattern1ReverseWrap;

        private IAsmHook pattern1AsmHook;

        #endregion

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Units.OnValueChanged;

        public string HookName => "Player Remove Units.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern1Func = CodeToExecutePattern1;

            string pattern1 = "2B F8 89 B9 BC ? ? ? 48 8D 0D";
            long pattern1Address = new Signature(pattern1).Scan();

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}"
            };
            pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.DoNotExecuteOriginal).Activate();
        }

        private void CodeToExecutePattern1(int amountToRemove)
        {
            int currentUnits = Game.Instance.Player.Units;
            int newUnits = currentUnits - amountToRemove;
            amountChangedParam.value = newUnits;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            Game.Instance.Player.Units.Value = amountChangedParam;            
            ModEventHook.Postfix.Invoke(amountChangedParam);
        }
    }
}
