using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{
    public unsafe class Inventories_Update : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, long a2, long a3, long* a4, long a5, int a6, long a7, int a8, char a9);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; } = new SharedModEventHook();
        public string HookName => "InventoriesGUI_Update";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 89 5C 24 ? 48 89 6C 24 ? 4C 89 44 24 ? 56 57 41 54 41 55 41 57 48 81 EC ? ? ? ? 48 8B E9 48 C7 44 24";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, long a2, long a3, long* a4, long a5, int a6, long a7, int a8, char a9)
        {
            ModEventHook.Prefix.Invoke();
            var result = Hook.OriginalFunction(a1, a2, a3, a4, a5, a6, a7, a8, a9);
            ModEventHook.Postfix.Invoke();

            if (!Game.Instance.IsInventoryOpen)
            {
                Game.Instance.OnInventoriesOpened.Invoke();
            }

            return result;
        }
    }
}
