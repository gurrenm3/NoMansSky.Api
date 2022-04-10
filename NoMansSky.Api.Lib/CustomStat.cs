using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a custom stat that does not normally exist within the game.
    /// <br/>This is used to make brand new stats.
    /// </summary>
    /// <typeparam name="T">The type of the value that this stat will hold.</typeparam>
    public class CustomStat<T> : Stat<T>
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override T Value { get => (T)GetValue(); set => SetValue(value); }

        /// <summary>
        /// Backing field for <see cref="Value"/>.
        /// </summary>
        protected T _value;

        /// <summary>
        /// Creates a new instance of this class while setting it's name.
        /// </summary>
        /// <param name="name"></param>
        public CustomStat(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Returns the value of this stat.
        /// </summary>
        /// <returns></returns>
        protected virtual T GetValue()
        {
            return _value;
        }

        /// <summary>
        /// Sets the value of this stat.
        /// </summary>
        /// <param name="value"></param>
        protected virtual void SetValue(T value)
        {
            bool isValueChangedFiring = OnValueChanged.IsFiring;
            if (!isValueChangedFiring)
            {
                eventParams.value = value;
                OnValueChanged.Prefix.Invoke(eventParams);
                value = eventParams.value;
            }

            // setter code here


            if (!isValueChangedFiring)
            {
                OnValueChanged.Postfix.Invoke(eventParams);
            }
        }
    }
}
