using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.SpaceHooks
{
    public unsafe class OnWarpFinished : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long systemDataAddress, long a2);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        /// <summary>
        /// The mod event tied to when a planet gets loaded.
        /// </summary>
        public static IModEvent ModEvent => IGame.Instance?.OnWarpFinished!;

        #endregion

        
        public string HookName => "On Warp Finished";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 4C 24 ? 57 48 83 EC 30 48 C7 44 24 ? ? ? ? ? 48 89 5C 24 ? 48 89 74 24 ? 48 8B F2 48 8B F9 0F 10 02 0F 11 01 48";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        
        private long CodeToExecute(long systemDataAddress, long a2)
        {
            if (IGame.Instance.IsWarping)
            {
                ModEvent?.Invoke();
                IGame.Instance.CurrentSystem.OnSystemLoaded.Invoke(systemDataAddress);
            }

            var result = Hook.OriginalFunction(systemDataAddress, a2);

            return result;
        }
    }
}
