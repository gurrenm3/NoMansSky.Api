using Reloaded.Hooks.Definitions;
using Reloaded.ModHelper;
using System;
using System.Reflection;

namespace NoMansSky.Api
{
    public class HookDefinitionsUtils
    {
        public static IReloadedHooks hooksInstance;

        public static string TryGetPatternFromDelegate<T>() where T : Delegate
        {
            var type = typeof(T);
            var attr = type.GetCustomAttribute<FunctionAddressAttribute>();
            if (attr == null)
            {
                throw new Exception("Failed to get function attr");
            }

            return attr.pattern;
        }

        public static long GetAddressFromPattern(string pattern)
        {
            return new Signature(pattern).Scan();
        }

        public static long GetAddressFromDelegate<T>() where T : Delegate
        {
            var pattern = TryGetPatternFromDelegate<T>();
            return GetAddressFromPattern(pattern);
        }
    }
}
