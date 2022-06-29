using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GalaxyMapHooks
{
    public unsafe class OnSystemHighlighted : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, long a2, int a3, char a4);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        public static IModEvent<ISolarSystemData> ModEvent => IGame.Instance.GalaxyMap.OnSystemHighlighted;

        public string HookName => "GalaxyMap.OnSystemHighlighted";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "48 89 5C 24 ? 44 88 4C 24 ? 55";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, long a2, int a3, char a4)
        {
            // nothing here yet. Will look into more later.


            var result = Hook.OriginalFunction(a1, a2, a3, a4);

            var planetAddresses = GalaxyMapHooks.LoadPlanetFromHighlightedSystem.planetAddressesInSystem;
            ISolarSystemData systemData = new SolarSystemData();
            systemData.PlanetAddresses.AddRange(planetAddresses);

            ModEvent.Invoke(systemData);

            return result;
        }
    }
}
