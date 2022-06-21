using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class LoadPlayerProfile : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; set; } = new SharedModEventHook();
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static bool isLoadingProfile = false;

        public string HookName => "OnPlayerProfileLoaded";
        private IModLogger logger;
        DebugLogger debug;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            debug = new DebugLogger(logger);

            // keeping these for record. No longer used.
            //string patternOld = "40 55 56 57 41 54 41 55 41 56 41 57 48 8B EC 48 83 EC 50 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 4C 8B E9 48";
            //string patternOld2 = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";
            //string patternOld3 = "48 89 4C 24 ? 55 53 56 57 41 54 41 55 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 4C 8B E1 48"; // this is most accurate but might be a little too early

            
            

            string pattern = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";
            var address = new Signature(pattern).Scan();
            Function = _hooks.CreateFunction<HookDelegate>(address);
            Hook = Function.Hook(CodeToExecute).Activate();
            ModEventHook.Postfix += () => Game.Instance.OnProfileSelected.Invoke();
        }

       
        private long CodeToExecute(long a1)
        {
            //logger.WriteLine("0");
            isLoadingProfile = true;

            //logger.WriteLine("1");
            ModEventHook.Prefix.Invoke();

            //logger.WriteLine("2");
            var result = Hook.OriginalFunction(a1);

            //logger.WriteLine("3");
            isLoadingProfile = false;

            //logger.WriteLine("4");
            if (Game.Instance.Player.GcPlayerStateAddress == 0)
            {
                //logger.WriteLine("5");
                long playerStatePointer = GetPlayerStatePointer();

                //logger.WriteLine("6");
                Game.Instance.Player.OnPlayerStateAquired.Invoke(playerStatePointer);
            }

            //logger.WriteLine("7");
            ModEventHook.Postfix.Invoke();

            //logger.WriteLine("8");
            return result;
        }

        private long GetPlayerStatePointer()
        {
            //logger.WriteLine("a");
            long scanResult = new Signature("48 8D 1D ? ? ? ? 45 33 F6 41 8B").Scan();

            //logger.WriteLine("b");
            int offset = *(int*)(scanResult + 3);

            //logger.WriteLine("c");
            long address = (scanResult + 7) + offset; // address + 7 = the end of LEA instruction.

            //logger.WriteLine("d");
            address += 0x68; // adding 0x68 because that's the offset to the start of the player pointer

            //logger.WriteLine("e"); // it breaks here
            var gcPlayerStatePointer = MemoryUtils.GetAddressFromOffsets(address, 0xB8, 0x8, 0x158, 0x4D8, 0x40, 0);

            //logger.WriteLine("f");
            if (gcPlayerStatePointer == 0)
                logger.WriteLine("Failed to get Pointer to GcPlayerStateData!", LogLevel.Error);
            else
                logger.WriteLine($"[For CheatEngine Users] Pointer to GcPlayerStateAddress = Base Address: {address.ToString("X")}. Offsets: 0xB8, 0x8, 0x158, 0x4D8, 0x40, 0");

            //logger.WriteLine("g");

            logger.WriteLine($"Current gcPlayerStatePointer: {gcPlayerStatePointer}");
            var value = *(long*)gcPlayerStatePointer;

            //logger.WriteLine("h");
            return value;
        }
    }
}