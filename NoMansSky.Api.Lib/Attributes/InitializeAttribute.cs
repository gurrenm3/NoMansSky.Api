using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Used to make methods execute automatically after <see cref="Game.Instance"/> has finished being created.
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
        /// <param name="modMethodPair"></param>
        public override void OnAttributeLoaded(ModMethodAttributeInfo modMethodPair)
        {
            if (Game.Instance.IsInitialized)
            {
                modMethodPair.TargetMethod.Invoke(null, null);
            }

            Game.Instance.OnInitialized += () => modMethodPair.TargetMethod.Invoke(null, null);
        }
    }
}
