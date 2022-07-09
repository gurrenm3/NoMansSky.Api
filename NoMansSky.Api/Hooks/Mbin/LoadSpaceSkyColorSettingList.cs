using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.Mbin
{
    internal unsafe class LoadSpaceSkyColorSettingList : IModHook
    {

        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[2] { FunctionAttribute.Register.rax, FunctionAttribute.Register.r8 }, FunctionAttribute.Register.rax, false)]
        public delegate long OnChangedFunc2(long loadedMBinAddress, long mbinNameAddress);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 pattern2Func;
        private IAsmHook pattern2AsmHook;

        #endregion



        public string HookName => "LoadSpaceSkyColorSettingList";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            pattern2Func = CodeToExecutePattern2;
            string pattern2 = "48 8B 13 48 8D 0D ? ? ? ? E8 ? ? ? ? 48 89 84 1E ? ? ? ? ";
            long pattern2Address = new Signature(pattern2).Scan() + 15;
            string[] pattern2Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern2Func, out pattern2ReverseWrap)}",
            };

            //pattern2AsmHook = _hooks.CreateAsmHook(pattern2Asm, pattern2Address, AsmHookBehaviour.ExecuteAfter).Activate();
        }

        internal static List<long> addresses = new List<long>();
        
        private long CodeToExecutePattern2(long loadedMBinAddress, long mbinNameAddress)
        {
            string mbinFullName = Strings.ToString(mbinNameAddress + 0x8); // it's 8 bytes away from this address.

            if (!string.IsNullOrEmpty(mbinFullName))
            {
                string mbinName = mbinFullName?.Split('/')?.Last()?.Replace(".MBIN", "");
                SpaceColorSetting loadedMbin = null;
                if (mbinName.ToLower().Contains("rare")) // it's the rare one
                    loadedMbin = (SpaceColorSetting)IGame.Instance?.SpaceColors?.RareColorSettings;
                else
                    loadedMbin = (SpaceColorSetting)IGame.Instance?.SpaceColors?.DefaulColorSettings;

                //loadedMbin.Init(mbinFullName, loadedMBinAddress);
                //IGame.Instance.SpaceColors.OnColorLoaded.Invoke(loadedMbin);
                //IGame.Instance.MBinManager.RegisterMBin(loadedMbin);
            }
            else
            {
                logger.WriteLine("Failed to get the name of a space color mbin file. Unable to register it with the API", LogLevel.Error);
            }

            

            //long mbinNameAddress = 

            /*var actualName = Strings.ToString(mbinName);
            if (!string.IsNullOrEmpty(actualName))
            {
                logger.WriteLine($"Loaded space colr: {actualName}");
            }*/
            /*else
            {
                logger.WriteLine("Failed to get the name of a biome mbin file. Unable to register it with the API", LogLevel.Error);
            }*/

            return loadedMBinAddress;
        }

        private string ColorToString(Colour colour)
        {
            return $"({colour.R}, {colour.G}, {colour.B})";
        }
    }
}
