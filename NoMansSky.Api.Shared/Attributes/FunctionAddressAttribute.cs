using System;

namespace NoMansSky.Api
{
    [AttributeUsage(AttributeTargets.Delegate, AllowMultiple = true)]
    public class FunctionAddressAttribute : ModSettingAttribute
    {
        public GamePlatform Platform { get; set; }
        public bool IsXRefSig { get; set; }
        public string pattern;

        public FunctionAddressAttribute(string pattern)
        {
            this.pattern = pattern;
            Platform = GamePlatform.All;
        }

        public FunctionAddressAttribute(GamePlatform platform, string pattern)
        {
            Platform = platform;
            this.pattern = pattern;
        }

        public FunctionAddressAttribute(GamePlatform platform, bool isXrefSig, string pattern)
        {
            Platform = platform;
            IsXRefSig = isXrefSig;
            this.pattern = pattern;
        }
    }
}
