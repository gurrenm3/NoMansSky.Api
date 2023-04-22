using NoMansSky.Api;
using NoMansSky.Api.Definitions;
using NoMansSky.Api.TestMod.Configuration;
using Reloaded.ModHelper;
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

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                int randNum = Random.Range(0, 101);
                Game.TextChat.Say(randNum);
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                var g = Game;
                WriteLine("g");
                var text = g.TextChat;
                WriteLine("text");
                var input = text.Input;
                WriteLine("input");
                input.SetText("fff");
                WriteLine("set text");
            }

            //Game.GetGcApplication()->data->networkManager.voiceChat->
        }

        [NMSHook<cGcTextChatManager.AddPendingMessageFunc>]
        public static void AddPendingMessageFunc(long self, long pendingMessage)
        {
            var chatMgr = (cGcTextChatManager*)self;
            var msg = (PendingMessage*)pendingMessage;
            WriteLine($"Pending Message: {msg->UncensoredMessageBody.GetValue()}");
        }

        /*

        [NMSHook<cGcTextChatManager.SayFunc>(RunHook.Before)]
        public static void SayFunc(long self, long messageBody)
        {
            return;
            WriteLine("SayFunc");
        
            var text = (VirtualString<Size0x7F>*)messageBody;
            WriteLine($"Message was: {text->GetValue()}. Clearing it out!");
            text->SetValue("");
            *//*var chatMgr = (cGcTextChatManager*)self;
            var msg = (PendingMessage*)pendingMessage;

            var body = msg->getUncensoredMessageBody();
            WriteLine(body);*//*
        }*/

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