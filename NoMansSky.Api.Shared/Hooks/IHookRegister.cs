using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    public interface IHookRegister
    {
        /// <summary>
        /// The main instance of the hook register.
        /// </summary>
        public static IHookRegister instance;

        /// <summary>
        /// Register a hook.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="hook"></param>
        public void RegisterHook<T>(IModEventHook<object[]?> hook);

        /// <summary>
        /// Register a hook.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hook"></param>
        public void RegisterHook(string name, IModEventHook<object[]?> hook);

        /// <summary>
        /// Check whether or not a hook is already registered.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="registerdHook"></param>
        /// <returns></returns>
        public bool IsHookRegistered<T>(out IModEventHook<object[]?> registerdHook);

        /// <summary>
        /// Check whether or not a hook is already registered.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="registerdHook"></param>
        /// <returns></returns>
        public bool IsHookRegistered(string name, out IModEventHook<object[]?> registerdHook);
    }
}
