using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using static NoMansSky.Api.Hooks.Macros;
using static Reloaded.Hooks.Definitions.X64.FunctionAttribute;

namespace NoMansSky.Api.Hooks.InventoryHooks
{
    /// <summary>
    /// 
    /// </summary>
    internal unsafe class OnItemAmountIncreased : IModHook
    {
        #region Asm Hook Variables

        public static Register[] savedRegisters { get; } = new[] { Register.rbx, Register.rdi, Register.r12, Register.r13, Register.r14, Register.r15 };
        //[Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rsi }, FunctionAttribute.Register.rsi, false, new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax})]
        
        [Function(new Register[1] { Register.rsi }, Register.rsi, false, new[] { Register.rbx, Register.rdi, Register.r12, Register.r13, Register.r14, Register.r15 })]
        public delegate int OnLoadedFunc(int amountToAdd);

        public OnLoadedFunc pattern1Func;

        // this needs to be static due to how the API auto-registers hooks
        private IReverseWrapper<OnLoadedFunc> pattern1ReverseWrap;

        private IAsmHook pattern1AsmHook;

        #endregion

        public string HookName => "On Item Amount Increased.";
        private IModLogger logger;

        private bool firstRun = true;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern1Func = CodeToExecute;
            string pattern1 = "01 70 18 E9 ? ? ? ?";
            long pattern1Address = new Signature(pattern1).Scan();

            /*logger.WriteLine(pattern1Address);
            logger.WriteLine(pattern1Address.ToString("X"));*/

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}",
            };

            //pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.ExecuteFirst).Activate();
        }

        private int CodeToExecute(int amountToAdd)
        {
            MessageBox.Show("Break");
            logger.WriteLine($"Amount before change {amountToAdd}");
            return amountToAdd*=2;
        }
    }
}
