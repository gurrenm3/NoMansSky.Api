using NoMansSky.Api;
using System;

namespace Reloaded.ModHelper
{
    /// <summary>
    /// Used on methods to indicate that they should automatically be subscribed to a GameLoop.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class OnUpdateAttribute : ModMethodAttribute
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public OnUpdateAttribute()
        {

        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="loadAfterTypes"><inheritdoc/></param>
        public OnUpdateAttribute(params Type[] loadAfterTypes) : base(loadAfterTypes)
        {

        }

        /// <summary>
        /// This is automatically called for each <see cref="OnUpdateAttribute"/>.
        /// <br/>When it's called, the attribute will automatically subscribe <see cref="ModMethodAttributeInfo.TargetMethod"/>
        /// to the GameLoop.
        /// </summary>
        /// <param name="modMethodPair"><inheritdoc/></param>
        public override void OnAttributeLoaded(ModMethodAttributeInfo modMethodPair)
        {
            Game.Instance.OnUpdate.Postfix += () => modMethodPair.TargetMethod.Invoke(null, null);
        }
    }
}