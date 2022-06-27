using libMBIN.NMS;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// A converter for NMSStrings.
    /// </summary>
    public class NMSStringConverter : IMemoryConverter
    {
        IMemoryManager manager;

        public NMSStringConverter(IMemoryManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="typeToCheck"></param>
        /// <returns></returns>
        public bool CanConvert(Type typeToCheck)
        {
            return typeToCheck.IsAssignableTo(typeof(INMSString));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool CanConvert<T>()
        {
            return CanConvert(typeof(T));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(Type valueType, long address)
        {
            var text = manager.GetValue<string>(address);
            return NMSString.CreateFrom(valueType, text);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address)
        {
            var value = GetValue(typeof(T), address);
            return (T)value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        public void SetValue(long address, object valueToSet)
        {
            string text = ((INMSString)valueToSet).StringValue();
            manager.SetValue(address, text);
        }
    }
}
