using NoMansSky.Api.Hooks.GameHooks;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// The parent class for interacting with and getting all information from No Mans Sky.
    /// </summary>
    public sealed class Game : ReloadedGame, IGame
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public static Game? Instance { get; set; }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGalaxyMap GalaxyMap => _galaxyMap;
        private IGalaxyMap _galaxyMap;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISolarSystem CurrentSystem => _currentSystem;
        private ISolarSystem _currentSystem;

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
        public bool IsOnMainMenu { get; private set; }

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
        public bool IsLoadingIntoGame { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsProfileSelected { get; private set; }

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
        public IModEvent OnWarpStarted { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnWarpFinished { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsWarping { get; internal set; }


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
            Instance = this;
            IGame.Instance = this;

            
            GameLoop = new HookedGameLoop();
            GameLoop.Initialize();

            InitModEvents();

            _galaxyMap = new GalaxyMap();
            _currentSystem = new SolarSystem();

            Player = new Player(logger);
            (Player as Player)?.Init();

            _modWarning = new ModWarning(logger);

            OnInitialized.Invoke();
            IsInitialized = true;
        }

        private void InitModEvents()
        {
            // profile selected events
            OnProfileSelected += () =>
            {
                IsOnMainMenu = false;
                IsProfileSelected = true;
                IsLoadingIntoGame = true;
            };

            // game joined events
            OnGameJoined += () =>
            {
                IsInGame = true;
                IsLoadingIntoGame = false;
            };

            // Warp events
            OnWarpStarted += () => IsWarping = true;
            OnWarpFinished += () => IsWarping = false;

            // main menu events
            OnMainMenu += () =>
            {
                IsProfileSelected = false;
                IsInGame = false;
                IsOnMainMenu = true;
            };

            // other events
            OnInventoriesOpened += () => IsInventoryOpen = true;
            OnInventoriesClosed += () => IsInventoryOpen = false;
        }
    }
}
