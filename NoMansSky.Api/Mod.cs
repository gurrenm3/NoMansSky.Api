using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        public Mod(Game _game, IModConfig _config, IReloadedHooks _hooks, ILogger _logger) : base(_game, _config, _hooks, _logger)
        {
            
        }

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine("Up arrow pressed");
            }
        }
    }
}