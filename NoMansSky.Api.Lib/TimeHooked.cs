using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    public class TimeHooked : ITime
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public double DeltaTime => deltaTime;
        private double deltaTime = 0;

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
        public void Update(double elapsedTime)
        {
            if (totalSeconds == 0)
                totalSeconds = elapsedTime;

            deltaTime = elapsedTime - totalSeconds;
            totalSeconds = elapsedTime;
        }
    }
}
