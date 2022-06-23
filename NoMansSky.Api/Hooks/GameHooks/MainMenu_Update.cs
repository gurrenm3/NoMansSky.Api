using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{    
    public unsafe class MainMenu_Update : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long self, float someValue);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; } = new SharedModEventHook();
        public string HookName => "MainMenu.Update";
        private IModLogger logger;
        private bool firstRun = true;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 55 53 56 57 41 54 41 56 41 57 48 8D A8 ? ? ? ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 0F 29 70 B8 0F 29 78 A8 0F";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            Game.Instance.OnGameJoined += () => firstRun = true; // reset firstRun so OnMainMenu works again.
        }

        private long CodeToExecute(long self, float someValue)
        {
            ModEventHook.Prefix.Invoke();
            var result = Hook.OriginalFunction(self, someValue);
            ModEventHook.Postfix.Invoke();

            if (firstRun)
            {
                Game.Instance.OnMainMenu.Invoke();
                firstRun = false;
            }

            return result;
        }
    }
}
