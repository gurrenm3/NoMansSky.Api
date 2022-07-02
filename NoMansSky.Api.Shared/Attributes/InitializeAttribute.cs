using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Used to make methods execute automatically after <see cref="IGame.Instance"/> has finished being created.
    /// </summary>
    public class InitializeAttribute : ModMethodAttribute
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public InitializeAttribute()
        {

        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="loadAfterTypes"><inheritdoc/></param>
        public InitializeAttribute(params Type[] loadAfterTypes) : base(loadAfterTypes)
        {

        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void OnAttributeLoaded()
        {
            if (IGame.Instance.IsInitialized)
            {
                Info.TargetMethod.Invoke();
            }

            IGame.Instance.OnInitialized += () => Info.TargetMethod.Invoke();
        }
    }
}
