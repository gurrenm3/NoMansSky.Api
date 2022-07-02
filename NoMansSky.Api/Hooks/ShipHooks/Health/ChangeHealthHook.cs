using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.ShipHooks
{
    internal unsafe class ChangeHealthHook : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc(int amount);

        private IReverseWrapper<OnChangedFunc> patternReverseWrap;
        public OnChangedFunc patternFunc;
        private IAsmHook patternAsmHook;

        #endregion


        /// <summary>
        /// The stat this hook is tied to.
        /// </summary>
        private static Stat<int> Stat => IGame.Instance?.Player?.Ship?.Health;

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Stat?.OnValueChanged;


        private EventParam<int> amountChangedParam = new EventParam<int>();
        public string HookName => "On Ship Health Changed.";
        private int previousHealth = -1;
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

        private void CodeToExecutePattern(int amount)
        {
            if (previousHealth == amount)
                return;


            bool hasGcPlayerState = IGame.Instance?.Player != null && IGame.Instance.Player.HasGcPlayerState;

            // Player failed to initialize. Can't do hooking.
            if (Stat == null || !hasGcPlayerState)
            {
                logger.WriteLine("Failed to update Ship's health because the API failed to get the Player's address.", LogLevel.Error);
                return;
            }

            previousHealth = amount;
            amountChangedParam.value = amount;

            Stat.OnValueChanged.Prefix.Invoke(amountChangedParam);

            Stat.Value = amountChangedParam.value;

            Stat.OnValueChanged.Postfix.Invoke(amountChangedParam);
        }
    }
}
