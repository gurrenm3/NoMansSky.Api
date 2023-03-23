using System;
using System.Reflection;

namespace NoMansSky.Api
{
    [AttributeUsage(AttributeTargets.Delegate)]
    public class FunctionAddressAttribute : ModSettingAttribute
    {
        public string pattern;
        public long scannedAddress;

        public FunctionAddressAttribute(string pattern)
        {
            this.pattern = pattern;
        }
    }
}
