using libMBIN;
using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.SpaceHooks
{
    internal unsafe class Planet_Update : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long planetAddress, long a2, long a3);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// The mod event tied to when a planet gets loaded.
        /// </summary>
        public static IModEvent<long> ModEvent => IGame.Instance?.CurrentSystem?.OnPlanetLoaded!;


        public string HookName => "On Planet Updated";
        private IModLogger logger;
        private HashSet<long> planetAddresses = new HashSet<long>();
        private MemoryManager memory = new MemoryManager();

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 8B C4 53 48 81 EC ? ? ? ? 48 89 78 18";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();

            IGame.Instance.OnWarpStarted += () => planetAddresses.Clear();
        }

        const int offsetToBaseAddress = 0x60;
        private long CodeToExecute(long planetAddress, long a2, long a3)
        {
            long actualPlanetAddress = planetAddress + offsetToBaseAddress;
            if (!planetAddresses.Contains(actualPlanetAddress))
            {
                if (ModEvent != null)
                    ModEvent.Invoke(actualPlanetAddress);

                planetAddresses.Add(actualPlanetAddress);

                int planetNameOffset = NMSTemplate.OffsetOf(typeof(GcPlanetData), nameof(GcPlanetData.Name));
                long planetNameAddress = actualPlanetAddress + planetNameOffset;
                string planetName = memory.GetValue<string>(planetNameAddress);

                string msg = string.Format("Loaded Planet->  Name: {0,-18}  GcPlanetData Address: {1, -12}", planetName, actualPlanetAddress.ToHex());
                logger.WriteLine(msg, LogLevel.CheatEngine);
            }

            var result = Hook.OriginalFunction(planetAddress, a2, a3);

            return result;
        }
    }
}
