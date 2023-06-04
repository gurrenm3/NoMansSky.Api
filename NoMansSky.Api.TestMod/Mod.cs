using NoMansSky.Api;
using NoMansSky.Api.Definitions;
using NoMansSky.Api.TestMod.Configuration;
using Reloaded.ModHelper;
using System.Reflection;
using static NoMansSky.Api.Definitions.cGcFrontendManager;
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

            //RuntimeCodeGenerator.GenerateCode();

            //RuntimeCodeGenerator2.GenerateCode();

            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;

            

            Console.WriteLine();
            /*Game.TextChat.Input.OnTextChanged.AddRunner(text =>
            {
                WriteLine(text);
            });*/

            /*Game.TextChat.OnSay.AddRunner((msg) =>
            {
                string msgText = msg.ToString();
                WriteLine("OnSay");
                WriteLine(msgText);
                if (!msgText.StartsWith("-time"))
                    return;

                if (msgText == "-time" || msgText == "-time get")
                {
                    var currentTime1 = Game.GetApplication()->data->simulation.environment.GetSky()->GetTimeOfDay();
                    Game.TextChat.Say($"Current time: {currentTime1}", true);
                    return;
                }

                string timeText = msgText.Replace("-time set ", "");
                if (!timeText.Contains("."))
                    timeText += ".0";

                float.TryParse(timeText, out float time);
                var currentTime = Game.GetApplication()->data->simulation.environment.GetSky()->GetTimeOfDay();
                timeDistance = currentTime - time;
            });*/

            cGcPlayerState state;
        }

        private Assembly? CurrentDomain_ReflectionOnlyAssemblyResolve(object? sender, ResolveEventArgs args)
        {
            Logger.WriteLine("aaa");
            return default;
        }

        private Assembly? CurrentDomain_AssemblyResolve(object? sender, ResolveEventArgs args)
        {
            
            Logger.WriteLine("bbb");
            return default;
        }

        private void CurrentDomain_AssemblyLoad(object? sender, AssemblyLoadEventArgs args)
        {
            Logger.WriteLine("ccc");
            
            
        }

        float timeDistance = 0;
        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                Popups.DisplayMessage("Testing 123", "This is a popup");

            }
        }

        [NMSHook<cGcFrontendManager.ShowQuitDialogFunc>(RunHook.Before)]
        public static void ShowQuitDialogFunc()
        {
            
            WriteLine("OnQuitDialog");
            /*onCloseFunc += (a, b, c) =>
            {
                OnCloseFunc(a, b, c);
            };*/
            return;

            // void (__fastcall *lpOnCloseFunc)(void *, bool, bool)

            /*long myCloseFuncPtr = Marshal.GetFunctionPointerForDelegate(OnCloseFunc);
            onCloseFunc = myCloseFuncPtr;*//*

            WriteLine("Making delegate");
            close = Marshal.GetDelegateForFunctionPointer<OnCloseCallback>((nint)onCloseFunc);
            WriteLine("SUccess!!!");

            WriteLine("Subscribing to delegate");
            close += (a, b, c) =>
            {
                OnCloseFunc(a, b, c);
            };
            WriteLine("Success!");

            WriteLine("OnQuitDialog DONE");*/

        }

        
        //public OnCloseCallback close;

        static void OnCloseFunc(void* a1, bool a2, bool a3)
        {
            WriteLine("My custom OnCloseFunc is working!!!!!");
        }


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