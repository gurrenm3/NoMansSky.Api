using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Linq;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.Player
{
    internal unsafe class GetDefaultInventoryBalance : IModHook
    {

        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rax }, FunctionAttribute.Register.rax, false)]
        public delegate long OnChangedFunc2(long addressToObject);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion



        public string HookName => "GetDefaultInventoryBalance";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern2Func = CodeToExecutePattern2;
            string pattern2 = "48 8D 8F ? ? ? ? 48 8B D0 E8 ? ? ? ? E8 ? ? ? ? ";
            long pattern2Address = new Signature(pattern2).Scan() + 15;
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
            };

            pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteFirst).Activate();
        }

        
        private long CodeToExecutePattern2(long addressToObject)
        {
            ((InventoryStoreBalance)IGame.Instance.Player.DefaultInventoryBalance).SetAddress(addressToObject);
            return addressToObject;
        }
    }
}
