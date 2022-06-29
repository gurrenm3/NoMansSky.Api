using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Collections.Generic;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.SpaceHooks
{
    public unsafe class Planet_Update : IModHook
    {
        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.rbx }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc2(long planetAddress);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion


        public string HookName => "On Planet Update";
        private IModLogger logger;
        private static HashSet<long> planetAddresses = new HashSet<long>();

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            pattern2Func = CodeToExecutePattern2;

            string pattern2 = "48 8D 53 60 48 8D BB ? ? ? ?";
            long pattern2Address = new Signature(pattern2).Scan();
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
            };

            //pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter).Activate(); //, hookLength: 15
        }

        private void CodeToExecutePattern2(long planetAddress)
        {
            if (planetAddresses.Contains(planetAddress))
                return;

            planetAddresses.Add(planetAddress);
            logger.WriteLine($"Planet Address: {planetAddress.ToHex()}");
        }
    }
}
