using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Defines when a hook should run in relation to the hooked function.
    /// </summary>
    public enum RunHook
    {
        /// <summary>
        /// Hook should run BEFORE the original function.
        /// </summary>
        Before,

        /// <summary>
        /// Hook should run AFTER the original function.
        /// </summary>
        After
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class NMSHookAttribute : ModSettingAttribute
    {
        public Type ClassToHook { get; protected set; }
        public string MethodToHook { get; protected set; }
        public RunHook HookTime { get; protected set; }

        public NMSHookAttribute(Type classToHook, string methodToHook, RunHook hookTime = RunHook.After)
        {
            ClassToHook = classToHook;
            MethodToHook = methodToHook;
            HookTime = hookTime;
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class NMSHookAttribute<T> : NMSHookAttribute
    {
        public NMSHookAttribute(string methodToHook, RunHook hookType = RunHook.After) : base(typeof(T), methodToHook, hookType)
        {

        }
    }
}
