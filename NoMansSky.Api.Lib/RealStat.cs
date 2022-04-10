using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a real stat that exists within the game and therefore has a corrisponding memory address/pointer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public unsafe class RealStat<T> : Stat<T>
    {
        /// <summary>
        /// The address of the stat.
        /// </summary>
        public long Address => _address;

        /// <summary>
        /// Backing field for <see cref="Address"/>.
        /// </summary>
        protected long _address;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override T Value { get => (T)GetValue(); set => SetValue(value); }

        /// <summary>
        /// Used to track whether or not this stat has finished initializing and can be safely used.
        /// </summary>
        protected bool _isInitialized;

        /// <summary>
        /// Creates a new instance of this class without setting any of it's values.
        /// </summary>
        public RealStat()
        {

        }

        /// <summary>
        /// Craetes a new <see cref="Stat{T}"/> with it's name and address.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public RealStat(string name, long address)
        {
            Init(name, address);
        }

        /// <summary>
        /// Initializes this stat with it's name and address.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public virtual void Init(string name, long address)
        {
            if (_isInitialized)
                return;

            _name = name;
            _address = address;
            _isInitialized = true;
        }

        /// <summary>
        /// Returns the value of this stat in memory.
        /// </summary>
        /// <returns></returns>
        protected virtual object GetValue()
        {
            if (!_isInitialized)
                throw new Exception($"Tried getting the value from the {nameof(Stat<T>)} named {Name} however it wasn't initialzed");

            var type = typeof(T);
            if (type == typeof(bool))
                return *(bool*)_address;
            if (type == typeof(byte))
                return *(byte*)_address;
            if (type == typeof(int))
                return *(int*)_address;
            if (type == typeof(long))
                return *(long*)_address;
            if (type == typeof(ulong))
                return *(ulong*)_address;
            if (type == typeof(float))
                return *(float*)_address;
            if (type == typeof(double))
                return *(double*)_address;
            if (type == typeof(decimal))
                return *(decimal*)_address;
            if (type == typeof(char))
                throw new NotImplementedException();
            if (type == typeof(string))
                throw new NotImplementedException();
            return default;
        }

        /// <summary>
        /// Sets the value of this stat in memory.
        /// </summary>
        /// <param name="value"></param>
        protected virtual void SetValue(object value)
        {
            if (!_isInitialized)
                throw new Exception($"Tried setting the value from the {nameof(Stat<T>)} named {Name} however it wasn't initialzed");

            bool isValueChangedFiring = OnValueChanged.IsFiring;
            if (!isValueChangedFiring)
            {
                eventParams.value = (T)value;
                OnValueChanged.Prefix.Invoke(eventParams);
                value = eventParams.value;
            }

            var type = typeof(T);
            if (type == typeof(bool))
            {
                *(bool*)_address = (bool)value;
            }
            else if (type == typeof(byte))
            {
                *(byte*)_address = (byte)value;
            }
            else if (type == typeof(int))
            {
                *(int*)_address = (int)value;
            }
            else if (type == typeof(long))
            {
                *(long*)_address = (long)value;
            }
            else if (type == typeof(ulong))
            {
                *(ulong*)_address = (ulong)value;
            }
            else if (type == typeof(float))
            {
                *(float*)_address = (float)value;
            }
            else if (type == typeof(double))
            {
                *(double*)_address = (double)value;
            }
            else if (type == typeof(decimal))
            {
                *(decimal*)_address = (decimal)value;
            }
            else if (type == typeof(char))
                throw new NotImplementedException();
            else if (type == typeof(string))
                throw new NotImplementedException();
            else
            {
                throw new NotImplementedException($"Failed to set type for the {nameof(Stat<T>)} with the name of {Name}" +
                    $" because this type is not currently supported.");
            }

            if (!isValueChangedFiring)
            {
                OnValueChanged.Postfix.Invoke(eventParams);
            }
        }
    }
}
