using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// A time class that is hooked to the game.
    /// </summary>
    internal class HookedTime : ITime
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public float DeltaTime => deltaTime;
        private float deltaTime = 0;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public double TotalMilliseconds => TotalSeconds * 1000;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public double TotalSeconds => totalSeconds;
        private double totalSeconds = 0;

        /// <summary>
        /// Update the Time variables based on the current <paramref name="elapsedTime"/>
        /// </summary>
        /// <param name="elapsedTime"></param>
        public void Update(float elapsedTime)
        {
            totalSeconds = elapsedTime;
            deltaTime = elapsedTime - (float)totalSeconds;
        }
    }
}
