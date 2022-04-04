using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class LoadGcPlayerStateData : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, long a2, long* a3);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static int loopCounter = 0; // this is used to track which loop iteration the original method is on.

        public string HookName => "LoadGcPlayerStateData";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 57 41 54 41 55 41 56 41 57 48 83 EC 20 45 33 ED 49 8B E8 45 8B FD";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        const int gcPlayerStateIndex = 42; // currently it is loaded on the 43rd iteration, so we run the loop after the 42.
        private long CodeToExecute(long a1, long a2, long* a3)
        {
            // this method is called many times when the player loads a save.
            if (!LoadPlayerProfile.isLoadingProfile)
                return Hook.OriginalFunction(a1, a2, a3);

            long result = 0;
            if (loopCounter == gcPlayerStateIndex)
            {
                result = OnLoadGcPlayerStateData(a1, a2, a3);
            }
            else
            {
                result = Hook.OriginalFunction(a1, a2, a3);
            }

            loopCounter++;
            return result;
        }

        private long OnLoadGcPlayerStateData(long a1, long a2, long* a3)
        {
            long result = 0;

            result = Hook.OriginalFunction(a1, a2, a3);

            var v10 = *(long*)(a1 + 24);
            long v25 = 0;


            /*
             notes on trying to get GcPlayerStateData pointer:


            
             */

            logger.WriteLine("LoadGcPlayerStateData - Postfix");

            return result;
        }
    }
}
