using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// A base class for No Man's Sky mods.
    /// </summary>
    public class NMSMod : ReloadedMod
    {
        /// <summary>
        /// Represents the instance of the Game class.
        /// </summary>
        public IGame Game => IGame.Instance;

        /// <summary>
        /// Represents the instance of the Game Loop.
        /// </summary>
        public IGameLoop GameLoop => Game.GameLoop;

        /// <summary>
        /// Represents the instance of the Player class.
        /// </summary>
        public IPlayer Player => Game.Player;

        /// <summary>
        /// Represents the player's exosuit.
        /// </summary>
        public IExosuit Exosuit => Game.Player.Exosuit;

        /// <summary>
        /// Represents the player's current ship.
        /// </summary>
        public IShip ActiveShip => Game.Player.ActiveShip;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            GameLoop.OnUpdate.Postfix += Update;
        }

        /// <summary>
        /// Called once every time the game loop runs.
        /// <br/>This will run in the PostFix of the Game loop.
        /// </summary>
        public virtual void Update() { }
    }
}
