using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public sealed class Game : ReloadedGame, IGame
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static Game Instance => _instance;

        /// <summary>
        /// Backing field for <see cref="Instance"/>.
        /// </summary>
        private static Game _instance = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPlayer Player { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBinManager MBinManager { get; set; } = new MBinManager();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInGame { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInventoryOpen { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModWarning ModsWarning => _modWarning;
        private IModWarning _modWarning;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnInitialized { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnMainMenu { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnProfileSelected { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnGameJoined { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnInventoriesOpened { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnInventoriesClosed { get; set; } = new SharedModEvent();

        private IModLogger logger;

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public Game(IModLogger apiLogger)
        {
            if (Instance != null)
                return;

            logger = apiLogger;
            Initialize();
        }

        /// <summary>
        /// Used by the API to initialize some of the game info.
        /// </summary>
        /// <returns></returns>
        private void Initialize()
        {
            _instance = this;
            IGame.Instance = this;

            //GameLoop = new HookedGameLoop();
            GameLoop = new HookedGameLoop();
            GameLoop.Initialize();

            OnGameJoined += () => IsInGame = true;
            OnInventoriesOpened += () => IsInventoryOpen = true;
            OnInventoriesClosed += () => IsInventoryOpen = false;

            Player = new Player(logger);
            (Player as Player)?.Init();

            _modWarning = new ModWarning(logger);

            OnInitialized.Invoke();
            IsInitialized = true;
        }
    }
}
