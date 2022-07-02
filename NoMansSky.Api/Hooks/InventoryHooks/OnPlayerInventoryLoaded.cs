using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.InventoryHooks
{
    /// <summary>
    /// 
    /// </summary>
    internal unsafe class OnPlayerInventoryLoaded : IModHook
    {
        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rbx }, FunctionAttribute.Register.rbx, false)]
        public delegate long OnLoadedFunc(long address);

        public OnLoadedFunc pattern1Func;

        // this needs to be static due to how the API auto-registers hooks
        private IReverseWrapper<OnLoadedFunc> pattern1ReverseWrap;

        private IAsmHook pattern1AsmHook;

        #endregion

        public string HookName => "On Inventory loaded.";
        private IModLogger logger;

        private bool firstRun = true;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern1Func = CodeToExecute;

            //string pattern1 = "48 83 03 08 EB 1B";
            string pattern1 = "49 8D 0C 3E 4C 8B 05 ? ? ? ? ";
            long pattern1Address = new Signature(pattern1).Scan();
            string[] pattern1Asm =
            {
                $"{_use32}",

                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}",
            };

            //pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.ExecuteFirst).Activate();
        }

        long address = 0;
        private long CodeToExecute(long inventoryAddress)
        {
            if (!firstRun)
            {
                pattern1AsmHook.Disable();
                return inventoryAddress;
            }

            address = inventoryAddress;
            logger.WriteLine($"Inventory address: {address}");
            firstRun = false;
            return inventoryAddress;
        }
    }
}
