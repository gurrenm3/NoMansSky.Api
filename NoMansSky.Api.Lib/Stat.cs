using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// A base class for dealing with and manipulating Stats from the game.
    /// </summary>
    /// <typeparam name="T">The type of value this stat holds.</typeparam>
    public abstract unsafe class Stat<T>
    {
        /// <summary>
        /// Called automatically when the value of this stat changes.
        /// </summary>
        public IModEventHook<T> OnValueChanged { get; set; }

        /// <summary>
        /// The name of this stat.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// The current value of this stat.
        /// </summary>
        public virtual T Value { get; set; }

        /// <summary>
        /// backing field for <see cref="Name"/>.
        /// </summary>
        protected string _name;        

        /// <summary>
        /// EventParams used to pass the value of this stat to <see cref="Stat{T}.OnValueChanged"/>.
        /// </summary>
        protected EventParam<T> eventParams = new EventParam<T>();

        /// <summary>
        /// Creates a new <see cref="Stat{T}"/> without assigning it's fields and properties.
        /// </summary>
        public Stat()
        {

        }

        /// <summary>
        /// Returns the value of this stat as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator T(Stat<T> stat)
        {
            return stat.Value;
        }
    }
}
