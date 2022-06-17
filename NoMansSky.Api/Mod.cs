using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        /// <summary>
        /// Used for logging messages within the api. Not necessary for your mods.
        /// </summary>
        internal static Mod Instance { get; private set; }

        public override bool ShouldUpdateSettings => true;

        ModSettingBool allowDoubleJump = new ModSettingBool(true);
        ModSettingBool allowDoubleJump2 = new ModSettingBool();
        ModSettingInt maxHealth = new ModSettingInt(1000);
        ModSettingDouble speed = new ModSettingDouble(60.412);
        ModSettingString username = new ModSettingString("Gurrenm3");

        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            
        }

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }

        protected override void OnInitialized()
        {
            WriteLine(username.Value);
            settingsManager.onSettingsChanged += () =>
            {
                Logger.WriteLine($"Username changed to: {username.Value}");
            };
        }

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
        }

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}