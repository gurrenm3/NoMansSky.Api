using libMBIN;
using Reloaded.Hooks;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Windows
{
    /// <summary>
    /// Utility which allows you to execute a given piece of code upon process exit.
    /// </summary>
    public class ProcessExit : IModHook
    {
        /// <summary>
        /// Executed when the process is about to exit.
        /// </summary>
        public event Action OnProcessExit;

        public static IFunction<ExitProcess> _function;
        public static IHook<ExitProcess> _exitProcessHook;

        public string HookName => "Process Exit";

        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            // Hook native import for ExitProcess. (So we can save log on exit)
            var kernel32 = Kernel32.GetModuleHandle("kernel32.dll");
            var address = Kernel32.GetProcAddress(kernel32, "ExitProcess");
            if (address != IntPtr.Zero)
            {
                logger.WriteLine("==================== Init Process Exit Hook ====================");

                _function = _hooks.CreateFunction<ExitProcess>((long)address);
                logger.WriteLine("ProcessExit is temporarily disabled...");
                //_exitProcessHook = _function.Hook(ExitProcessImpl).Activate();
            }
        }

        private void ExitProcessImpl(uint uexitcode)
        {
            string path = "F:\\Program Files (x86)\\Steam\\steamapps\\common\\No Man's Sky\\GAMEDATA\\MODS\\NoMansSky.HotReload\\Process Exit Success.txt";
            File.WriteAllText(path, "ABCD");

            OnProcessExit?.Invoke();
            _exitProcessHook.OriginalFunction(uexitcode);
        }


        [Reloaded.Hooks.Definitions.X64.Function(Reloaded.Hooks.Definitions.X64.CallingConventions.Microsoft)]
        [Reloaded.Hooks.Definitions.X86.Function(Reloaded.Hooks.Definitions.X86.CallingConventions.Cdecl)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ExitProcess(uint uExitCode);
    }
}
