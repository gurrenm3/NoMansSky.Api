using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Collections.Generic;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.GalaxyMapHooks
{
    public unsafe class LoadPlanetFromHighlightedSystem : IModHook
    {
        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[1] { FunctionAttribute.Register.r15 }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc2(long planetAddress);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion


        public string HookName => "Get Planet Info from Highlighted System.";
        private IModLogger logger;

        internal static HashSet<long> planetAddressesInSystem = new HashSet<long>();

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            pattern2Func = CodeToExecutePattern2;

            string pattern2 = "83 F9 01 0F 94 C0 41 88 87 ? ? ? ? ";
            long pattern2Address = new Signature(pattern2).Scan();
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
            };

            // this is kind of broken so it's not being used rn. Look more into later
            /*pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter).Activate();

            GalaxyMapHooks.Planet_Update2.ModEvent.AddListener((systemData) =>
            {
                planetAddressesInSystem.Clear();
            });*/
        }

        private void CodeToExecutePattern2(long planetAddress)
        {
            planetAddressesInSystem.Add(planetAddress);

            return;

            logger.WriteLine(planetAddress.ToHex());

            logger.WriteLine("Try cast:");

            var memoryMgr = new MemoryManager();
            var planetName = memoryMgr.GetValue<NMSString0x80>(planetAddress);

            logger.WriteLine("Got Planet. Planet name is about to be printed:");

            logger.WriteLine(planetName);

            logger.WriteLine("Done printing planet name");
        }
    }
}
