using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{    
    public unsafe class MainMenu_Update : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long self, float someValue);
        
        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }

        public string HookName => "MainMenu.Update";
        private ModLogger logger;
        private bool firstRun = true;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 55 53 56 57 41 54 41 56 41 57 48 8D A8 ? ? ? ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 0F 29 70 B8 0F 29 78 A8 0F";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            // Need to figure out how to tell when we left the main menu.
            //Game.Instance.OnProfileSelected += () => firstRun = true; // reset first run so OnMainMenu works again.
        }

        private long CodeToExecute(long self, float someValue)
        {            
            var result = Hook.OriginalFunction(self, someValue);

            if (firstRun)
            {
                Game.Instance.OnMainMenu.Invoke();
                firstRun = false;
            }

            return result;
        }
    }
}
