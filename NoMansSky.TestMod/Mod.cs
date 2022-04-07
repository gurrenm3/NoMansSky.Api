using NoMansSky.Api;
using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using System;

namespace NoMansSky.TestMod
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
            //Logger.WriteLine("Update from test mod!");
        }
    }
}