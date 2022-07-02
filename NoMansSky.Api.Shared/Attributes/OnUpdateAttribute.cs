using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Used on methods to indicate that they should automatically be subscribed to a GameLoop.
    /// </summary>
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
        /// <br/>When it's called, the attribute will automatically subscribe <see cref="ModAttrInfo.TargetMethod"/>
        /// to the GameLoop.
        /// </summary>
        public override void OnAttributeLoaded()
        {
            IGame.Instance.GameLoop.OnUpdate.Postfix += () => Info.TargetMethod.Invoke();
        }
    }
}