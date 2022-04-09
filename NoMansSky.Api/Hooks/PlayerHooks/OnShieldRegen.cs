using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class OnShieldRegen : IModHook
    {
        #region Asm Hook testing

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate int OnChangedFunc(int regenAmount);

        public static OnChangedFunc pattern1Func;
        public static OnChangedFunc pattern2Func;

        // this needs to be static due to how the API auto-registers hooks
        private static IReverseWrapper<OnChangedFunc> pattern1ReverseWrap;
        private static IReverseWrapper<OnChangedFunc> pattern2ReverseWrap;

        private static IAsmHook pattern1AsmHook;
        private static IAsmHook pattern2AsmHook;
        #endregion




        public static IFunction<OnChangedFunc> Function { get; set; }

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Shield.OnValueChanged;

        public string HookName => "On Player Shield Regenerated.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern1Func = CodeToExecutePattern1;            
            pattern2Func = CodeToExecutePattern2;            

            string pattern1 = "01 BB ? ? ? ? 48 8B CB E8 ? ? ? ? 8B";
            long pattern1Address = new Signature(pattern1).Scan();

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}",
                //$"mov {_edi}, 0" // set the original value to 0 so the game doesn't actually assign it.
                $"add {_edi}, rax" // set the original value to 0 so the game doesn't actually assign it.
            };
            pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.ExecuteFirst).Activate();



            string pattern2 = "89 83 ? ? ? ? F3 0F 10 05 ? ? ? ? F3 0F 5C";
            long pattern2Address = new Signature(pattern2).Scan();
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
                $"mov {_eax}, rax"
            };
            pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteFirst).Activate();
        }

        private int CodeToExecutePattern1(int regenAmount)
        {
            logger.WriteLine($"CodeToExecutePattern1 was called from Asm!");

            amountChangedParam.value = regenAmount;
            ModEventHook.Prefix.Invoke(amountChangedParam);

            return amountChangedParam.value;
        }

        private int CodeToExecutePattern2(int regenAmount)
        {
            logger.WriteLine($"CodeToExecutePattern2 was called from Asm! - RegenAmount = {regenAmount}");

            ModEventHook.Postfix.Invoke(amountChangedParam);
            return regenAmount;
        }

        /*private void CodeToExecutePattern1(int regenAmount)
        {
            logger.WriteLine($"CodeToExecutePattern1 was called from Asm!");

            amountChangedParam.value = regenAmount;
            ModEventHook.Prefix.Invoke(amountChangedParam);

            Game.Instance.Player.RaiseShield(amountChangedParam.value);
        }


        private void CodeToExecutePattern2(int regenAmount)
        {
            logger.WriteLine($"CodeToExecutePattern2 was called from Asm!");

            ModEventHook.Postfix.Invoke(amountChangedParam);
        }*/
    }
}
