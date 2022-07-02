using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    internal unsafe class ChangeHealthHook : IModHook
    {
        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc2(int regenAmount);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion


        /// <summary>
        /// The stat this hook is tied to.
        /// </summary>
        private static Stat<int> Stat => IGame.Instance?.Player?.Health;

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Stat?.OnValueChanged;


        private EventParam<int> amountChangedParam = new EventParam<int>();
        public string HookName => "On Player Health Changed.";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            // Info about this hook:
            // When it comes to setting the player's health, there are 2 lines in the middle of a Player.ChangeHealth method that
            // deal with this. Unfortunately if the player has taken damage and then gets into their ship, this method gets called in
            // Player.Update over and over. This means that hooking the method is not possible and instead ASM hooks are needed
            // to change just those 2 lines. I was able to get it working by just changing the second line of ASM.

            logger = _logger;
            pattern2Func = CodeToExecutePattern2;

            string pattern2 = "3B CF 48 8B 74 24 ? 0F";
            long pattern2Address = new Signature(pattern2).Scan() + 15; // this pattern is 15 bytes before the one we want so add offset.
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",

                // this line is no longer used because the ASM hook changed.
                //$"mov {_eax}, rax" // moves the return value of function below into eax, the register the game uses to change shield
            };

            // hookLength is 13 because the original line failed to be hooked. Instead it's hooking both this line and the line
            // above it, for a total lenght of 15 bytes
            pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter, hookLength: 15).Activate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCurrentHealth">the final health value after it's been changed in during the first ASM line.</param>
        private void CodeToExecutePattern2(int newCurrentHealth)
        {
            amountChangedParam.value = newCurrentHealth;
            ModEventHook.Prefix.Invoke(amountChangedParam);

            bool hasGcPlayerState = IGame.Instance?.Player != null && IGame.Instance.Player.HasGcPlayerState;
            if (hasGcPlayerState)
                Stat.Value = amountChangedParam.value;

            ModEventHook.Postfix.Invoke(amountChangedParam);
        }
    }
}
