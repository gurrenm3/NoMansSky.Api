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

namespace NoMansSky.Api.Hooks.Mbin.Weather
{
    internal unsafe class LoadWeatherEffectTable : IModHook
    {

        #region Asm Hook Variables

        [Function(new FunctionAttribute.Register[2] { FunctionAttribute.Register.rax, FunctionAttribute.Register.r8 }, FunctionAttribute.Register.rax, false)]
        public delegate long OnChangedFunc2(long loadedMBinAddress, long mbinNameAddress);

        private IReverseWrapper<OnChangedFunc2> pattern2ReverseWrap;
        public OnChangedFunc2 hookFunc;
        private IAsmHook weatherEffectsAsmHook;
        private IAsmHook weatherHazardsAsmHook;

        #endregion



        public string HookName => "LoadWeatherEffectTable";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C8 E8 ? ? ? ? 49 89 87 ? ? ? ? 48 83 C4 48 ";
            long patternAddress = new Signature(pattern).Scan();
            long weatherEffectsAddress = patternAddress - 0x16;
            long weatherHazardsAddress = patternAddress + 0x8;

            hookFunc = CodeToExecutePattern;
            
            
            string[] hookAsm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(hookFunc, out pattern2ReverseWrap)}",
            };

            //weatherEffectsAsmHook = _hooks.CreateAsmHook(hookAsm, weatherEffectsAddress, AsmHookBehaviour.ExecuteFirst).Activate();
            //weatherHazardsAsmHook = _hooks.CreateAsmHook(hookAsm, weatherHazardsAddress, AsmHookBehaviour.ExecuteFirst).Activate();
        }

        private long CodeToExecutePattern(long loadedMBinAddress, long mbinNameAddress)
        {
            logger.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
            string mbinFullName = Strings.ToString(mbinNameAddress + 0x8); // it's 8 bytes away from this address.

            //logger.WriteLine($"Name: {mbinName} | Address {loadedMBinAddress.ToHex()}");

            if (!string.IsNullOrEmpty(mbinFullName))
            {
                string mbinName = mbinFullName?.Split('/')?.Last()?.Replace(".MBIN", "");

                WeatherEffectTable loadedMbin = null;
                if (mbinName.ToLower().Contains("effects")) // it's the WeatherEffects.mbin file
                    loadedMbin = (WeatherEffectTable)IGame.Instance?.WeatherData.WeatherEffects;
                else
                    loadedMbin = (WeatherEffectTable)IGame.Instance?.WeatherData.WeatherHazards;

                /*loadedMbin.Init(mbinFullName, loadedMBinAddress);
                IGame.Instance.MBinManager.RegisterMBin(loadedMbin);*/
            }
            else
            {
                logger.WriteLine("Failed to get the name of a space color mbin file. Unable to register it with the API", LogLevel.Error);
            }
            return loadedMBinAddress;
        }
    }
}
