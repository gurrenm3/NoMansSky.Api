using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class ChangeHealthHook : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rsi }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc1(int regenAmount);

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc2(int regenAmount);

        public OnChangedFunc1 pattern1Func;
        public OnChangedFunc2 pattern2Func;

        // this needs to be static due to how the API auto-registers hooks
        private IReverseWrapper<OnChangedFunc1> pattern1ReverseWrap;
        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;

        private IAsmHook pattern1AsmHook;
        private IAsmHook pattern2AsmHook;

        #endregion

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Health.OnValueChanged;

        public string HookName => "On Player Health Changed.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            // Info about this hook:
            // When it comes to setting the player's health, there are 2 lines in the middle of a Player.ChangeHealth method that
            // deal with this. Unfortunately if the player has taken damage and then gets into their ship, this method gets called in
            // Player.Update over and over. This means that hooking the method is not possible and instead ASM hooks are needed
            // to change just those 2 lines. I was able to get it working by just changing the second line of ASM.

            logger = _logger;

            pattern1Func = CodeToExecutePattern1;
            pattern2Func = CodeToExecutePattern2;

            // pattern1 is no longer being used. Will remove later
            /*string pattern1 = "01 B3 ? ? ? ? E8 ? ? ? ? 8B 8B ? ? ? ? 3B CF 48";
            long pattern1Address = new Signature(pattern1).Scan();

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}",

                // line below is obsolete because the ASM hook is different now.
                //$"add {_edi}, rax" // moves the return value of function below into edi, the register the game uses to change shield
            };
            pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.ExecuteAfter).Activate();*/



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

        private int healthBetweenHooks = 0;

        /// <summary>
        /// This code corrolates to the first ASM line that needed to be patched.
        /// This changes how much should be regnenerated and fires the prefix ModEventHook.
        /// </summary>
        /// <param name="amountChanged"></param>
        private void CodeToExecutePattern1(int amountChanged)
        {
            /*var currentHealth = Game.Instance.Player.Health.Value;
            amountChangedParam.value = currentHealth + originalRegenAmount;
            ModEventHook.Prefix.Invoke(amountChangedParam);*/

            //healthBetweenHooks = amountChangedParam.value - currentHealth;
            //Game.Instance.Player.Health.Value = amountChangedParam.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCurrentHealth">the final health value after it's been changed in during the first ASM line.</param>
        private void CodeToExecutePattern2(int newCurrentHealth)
        {
            amountChangedParam.value = newCurrentHealth;
            ModEventHook.Prefix.Invoke(amountChangedParam);

            Game.Instance.Player.Health.Value = amountChangedParam.value;
            ModEventHook.Postfix.Invoke(amountChangedParam);
        }
    }
}
