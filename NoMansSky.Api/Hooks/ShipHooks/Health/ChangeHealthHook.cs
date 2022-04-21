using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.ShipHooks
{
    public unsafe class ChangeHealthHook : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc(int amount);

        public OnChangedFunc patternFunc;

        // this needs to be static due to how the API auto-registers hooks
        private IReverseWrapper<OnChangedFunc> patternReverseWrap;

        private IAsmHook patternAsmHook;

        #endregion

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Health.OnValueChanged;

        public string HookName => "On Ship Health Changed.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            patternFunc = CodeToExecutePattern;

            string pattern = "3B CF 0F 4F F9 3B F8 0F 4C C7 89 83 ? ? ? ?";
            long patternAddress = new Signature(pattern).Scan() + 10; // this pattern is 10 bytes before the one we want so add offset.
            string[] patternAsm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(patternFunc, out patternReverseWrap)}",
            };
            patternAsmHook = _hooks.CreateAsmHook(patternAsm, patternAddress, AsmHookBehaviour.DoNotExecuteOriginal).Activate();
        }

        private int previousHealth = -1;
        private void CodeToExecutePattern(int amount)
        {
            if (previousHealth == amount)
                return;

            previousHealth = amount;
            amountChangedParam.value = amount;

            var stat = Game.Instance.Player.Ship.Health;
            stat.OnValueChanged.Prefix.Invoke(amountChangedParam);

            stat.Value = amountChangedParam.value;

            stat.OnValueChanged.Postfix.Invoke(amountChangedParam);
        }
    }
}
