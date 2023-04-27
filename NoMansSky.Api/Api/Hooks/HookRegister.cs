using Reloaded.Hooks.Definitions;
using System.Reflection;

namespace NoMansSky.Api
{
    public unsafe class HookRegister : IHookRegister
    {
        public static HookRegister instance;
        public static IReloadedHooks hooksInstance;
        public Dictionary<string, IModEventHook<object[]?>> CurrentHooks { get; set; } = new();

        public HookRegister()
        {
            instance = this;
            IHookRegister.instance = this;
        }

        public void RegisterHook<T>(IModEventHook<object[]?> hook)
        {
            string hookName = GetHookName<T>();
            RegisterHook(hookName, hook);
        }

        public void RegisterHook(string name, IModEventHook<object[]?> hook)
        {
            if (CurrentHooks.ContainsKey(name))
                CurrentHooks[name] = hook;
            else
                CurrentHooks.Add(name, hook);
        }

        public bool IsHookRegistered<T>(out IModEventHook<object[]?> registerdHook)
        {
            string hookName = GetHookName<T>();
            return IsHookRegistered(hookName, out registerdHook);
        }

        public bool IsHookRegistered(string name, out IModEventHook<object[]?> registerdHook)
        {
            return CurrentHooks.TryGetValue(name, out registerdHook);
        }

        public static string GetHookName<T>()
        {
            string delegateName = typeof(T).Name;
            var indexOfName = typeof(T).FullName.IndexOf('+');
            if (indexOfName < 0)
                return delegateName;

            var parentClassFullName = typeof(T).FullName.Remove(indexOfName);
            var parentClassName = typeof(T).Assembly.GetType(parentClassFullName).Name;
            string hookName = $"{parentClassName}.{delegateName}";
            return hookName;
        }

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

        public static long GetAddressFromDelegate<T>(bool isXrefSig) where T : Delegate
        {
            var pattern = TryGetPatternFromDelegate<T>();
            var address = GetAddressFromPattern(pattern);
            if (isXrefSig)
                address = *(long*)address;

            return address;
        }
    }
}
