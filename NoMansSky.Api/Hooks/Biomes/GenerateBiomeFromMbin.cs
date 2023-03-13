using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Linq;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.GalaxyMap
{
    /// <summary>
    /// This was found by sharkeater#4523.
    /// <br/>Without their assistance this wouldn't be in the API.
    /// </summary>
    internal unsafe class GenerateBiomeFromMbin : IModHook
    {

        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[2] { FunctionAttribute.Register.rax, FunctionAttribute.Register.rbx }, FunctionAttribute.Register.rax, false)]
        public delegate long OnChangedFunc2(long biomeAddress, char* mbinName);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion



        public string HookName => "GenerateBiomeFromMbin";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern2Func = CodeToExecutePattern2;
            string pattern2 = "41 B0 01 48 8B D3 48 8D 0D ? ? ? ? E8 ? ? ? ? 48 89 45 60 ";
            long pattern2Address = new Signature(pattern2).Scan() + 13;
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
            };

            pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter).Activate();
        }

        
        private long CodeToExecutePattern2(long biomeAddress, char* mbinName)
        {
            var actualName = StringUtils.ToString(mbinName);
            if (!string.IsNullOrEmpty(actualName))
            {
                var environmentObject = new EnvironmentObject(actualName, biomeAddress);

                if (!IGame.Instance.EnvironmentObjects.Any(obj => obj.Equals(environmentObject)))
                    IGame.Instance.OnEnvironmentObjectLoaded.Invoke(environmentObject);
            }
            else
            {
                logger.WriteLine("Failed to get the name of a biome mbin file. Unable to register it with the API", LogLevel.Error);
            }

            return biomeAddress;
        }
    }
}
