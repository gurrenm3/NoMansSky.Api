using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    internal class HookedGameLoop : GameLoop
    {
        public override ITime Time => _time;
        private ITime _time = null!;

        public override long LoopCount => _loopCount;
        private long _loopCount;

        private bool isInitialized;

        /// <summary>
        /// This is used by the API to initialize the game loop.
        /// <br/>Can only be called once.
        /// </summary>
        /// <returns></returns>
        public override IGameLoop Initialize()
        {
            if (isInitialized)
                return this;
            
            _time = new HookedTime();
            OnUpdate = new SharedModEventHook();
            OnUpdate.Postfix += () => _loopCount++;
            isInitialized = true;

            return this;
        }
    }
}
