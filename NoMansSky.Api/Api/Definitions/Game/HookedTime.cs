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
        public float DeltaTime { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public double TotalMilliseconds => TotalSeconds * 1000;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public double TotalSeconds { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public DateTime Now => DateTime.Now;

        /// <summary>
        /// Update the Time variables based on the current <paramref name="elapsedTime"/>
        /// </summary>
        /// <param name="elapsedTime"></param>
        public void Update(float elapsedTime)
        {
            TotalSeconds = elapsedTime;
            DeltaTime = elapsedTime - (float)TotalSeconds;
        }
    }
}
