using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    /// <summary>
    /// Hook that deals with the player's shield regeneration.
    /// </summary>
    public unsafe class OnShieldRegen : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rdi }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc1(int regenAmount);

        [Function(CallingConventions.Microsoft)]
        public delegate void OnChangedFunc2();

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
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Shield.OnValueChanged;

        public string HookName => "On Player Shield Regenerated.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            // Info about this hook:
            // When it comes to Player Shield Regen, there are 2 lines in the middle of the Player.Update method that deal with regen.
            // In order to work with the API, both of the lines needed to be patched. Unlike normal function hooks, these lines were
            // in the middle of an existing method and therefore the actual assembly code for the method needed to be patched.
            // Patter1 represents the first line while pattern2 represents the second. These 2 asm hooks let the origianl line 
            // execute the way they were originally going to. Afterwards the asm hooks immediately run, undoing what those
            // 2 lines did and instead regenerating whatever amount was passed along through the ModEventHook. Even though the original
            // lines ran, they are invalidated afterwards because the shield health is manually changed to what we want it to be.

            logger = _logger;

            pattern1Func = CodeToExecutePattern1;
            pattern2Func = CodeToExecutePattern2;

            string pattern1 = "01 BB ? ? ? ? 48 8B CB E8 ? ? ? ? 8B";
            long pattern1Address = new Signature(pattern1).Scan();

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}",

                // line below is obsolete because the ASM hook is different now.
                //$"add {_edi}, rax" // moves the return value of function below into edi, the register the game uses to change shield
            };
            pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.ExecuteAfter).Activate();



            string pattern2 = "48 FF 83 ? ? ? ? 89 83 ? ? ? ? ";
            long pattern2Address = new Signature(pattern2).Scan();
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",

                // this line is no longer used because the ASM hook changed.
                //$"mov {_eax}, rax" // moves the return value of function below into eax, the register the game uses to change shield
            };

            // hookLength is 13 because the original line failed to be hooked. Instead it's hooking both this line and the line
            // above it, for a total lenght of 13 bytes
            pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter, hookLength: 13).Activate();
        }

        /// <summary>
        /// This code corrolates to the first ASM line that needed to be patched.
        /// This changes how much should be regnenerated and fires the prefix ModEventHook.
        /// </summary>
        /// <param name="originalRegenAmount"></param>
        private void CodeToExecutePattern1(int originalRegenAmount)
        {
            var currentShield = Game.Instance.Player.Shield.Value;
            amountChangedParam.value = currentShield + originalRegenAmount;
            ModEventHook.Prefix.Invoke(amountChangedParam);

            Game.Instance.Player.Shield.Value = amountChangedParam.value;
        }

        /// <summary>
        /// This code corrolates to the second ASM line that needed to be patched.
        /// This sets the shield to the new value, including the regenerated amount, and fires the postfix ModEventHook.
        /// </summary>
        private void CodeToExecutePattern2()
        {
            var postFixValue = amountChangedParam.value;
            Game.Instance.Player.Shield.Value = postFixValue;
            ModEventHook.Postfix.Invoke(amountChangedParam);
        }
    }
}
