using NoMansSky.Api;
using NoMansSky.Api.Definitions;
using NoMansSky.Api.TestMod.Configuration;
using Reloaded.ModHelper;
using System.Runtime.CompilerServices;
using Random = Reloaded.ModHelper.Random;

namespace NoMansSky.Api.TestMod
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        internal static Mod Instance { get; private set; }

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        public Config Configuration { get; set; }

        public Mod(ModContext context) : base(context)
        {
            Instance = this; // don't touch this

            /*Game.TextChat.Input.OnTextChanged.AddRunner(text =>
            {
                WriteLine(text);
            });*/

        }

        

        /*[NMSHook<cGcPlanet.GenerateFunc>(RunHook.Before)]
        public static void Generate(long self, long generationInputParams)
        {
            var planet = (cGcPlanet*)self;
            var colorPallets = planet->planetData.colours.getPalettes();
            var palette1 = colorPallets.GetElement(0);
            var colors = palette1->getColours();
            var color1 = colors.GetElement(0);
            color1->baseclass_0.Set(0.3f, 0.3f, 0.3f, 1);
        }*/

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                /*var planet = GetNthPlanet(3);
                WriteLine($"Details about planet: {planet->planetIndex}");*/
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                Game.GetGcApplication()->data->frontendManager.DisplayMessage("Title", "body");

                //Game.GetGcApplication()->data->frontendManager.ShowMessageBox(title, message);
            }


            //Game.GetGcApplication()->data->networkManager.voiceChat->
        }



        /*[NMSHook<cGcSolarSystem.ConstructFunc>]
        public static void SolarConstruct(long self)
        {
            *//*var ss = (cGcSolarSystem*)self;
            var planets = ss->getPlanets();
            var p = planets.GetElement(3);*//*


            var ss = (cGcSolarSystem*)self;
            var planets = ss->getPlanets();
            var planetsPtr = planets.GetPointer();
            var planets2 = (STDArray<cGcPlanet, Size0x6>*)planetsPtr;

            var p = planets2->GetElement(3);
            WriteLine($"Details about planet from cGcSolarSystem.ConstructFunc hook: {p->planetIndex}");
        }

        [NMSHook<cTkStoragePersistent.FetchSlotStatesFunc>]
        public static void FetchSlotStatesFunc(long self, long slotStates)
        {
            *//*var array = (STDArrayNew<cTkStoragePersistent.SlotState, Size0x20>*)slotStates;
            var timeStamp = array->GetElement(0x3)->valid;
            WriteLine($"Timestamp: {timeStamp}");*//*

            var array = STDArray<cTkStoragePersistent.SlotState, Size0x20>.FromPointer(slotStates);
            var timeStamp = array.GetElement(1)->timestamp;
            WriteLine($"Timestamp: {timeStamp}");
        }

        [NMSHook<cGcSolarSystem.UpdateFunc>]
        public static void SolarUpdate(long self)
        {
            if (Keyboard.IsPressed(Key.LeftArrow))
            {
                var ss = (cGcSolarSystem*)self;
                var planets = ss->getPlanets();
                var planetsPtr = planets.GetPointer();
                var planets2 = (STDArray<cGcPlanet, Size0x6>*)planetsPtr;

                var p = planets2->GetElement(3);
                WriteLine($"Details about planet from cGcSolarSystem.UpdateFunc hook: {p->planetIndex}");
            }            
        }


        public static cGcPlanet* GetNthPlanet(int idx)
        {
            WriteLine("1");
            var gcSimulation = IGame.Instance.GetGcApplication()->GetSimulation();
            WriteLine("2");
            var p_solarsystem = gcSimulation->solarSystem;
            WriteLine("3");
            var planets = p_solarsystem->getPlanets();
            WriteLine("4");
            int planet_count = planets.GetCount();
            WriteLine("5");
            // Cap the index to be less than the number of planets
            if (idx >= planet_count)
            {
                idx = planet_count - 1;
            }
            WriteLine("6");
            return planets.GetElement(idx);
        }
*/



        #region Standard Overrides

        // Attaches debugger to allow your mod to run with breakpoints.
        protected override bool EnableDebugger => false;

        public void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            Configuration = configuration;
            Logger.WriteLine($"[{ModConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion

        internal static void WriteLine(string text) => Instance.Logger.WriteLine(text);
        internal static void WriteLine(object text) => Instance.Logger.WriteLine(text);
    }
}