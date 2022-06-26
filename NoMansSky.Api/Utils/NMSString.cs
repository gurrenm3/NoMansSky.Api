using libMBIN.NMS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// Contains utilities for dealing with NMS Strings
    /// </summary>
    public static class NMSString
    {
        /// <summary>
        /// Contains string max lengths with corrisponding types.
        /// </summary>
        private static Dictionary<int, Type> strings = new Dictionary<int, Type>
        {
            { 10, typeof(NMSString0x10) },
            { 20, typeof(NMSString0x20) },
            { 40, typeof(NMSString0x40) },
            { 80, typeof(NMSString0x80) },
            { 100, typeof(NMSString0x100) },
            { 200, typeof(NMSString0x200) },
            { 400, typeof(NMSString0x400) },
            { 800, typeof(NMSString0x800) }
        };

        /// <summary>
        /// Returns the text held in this string.
        /// </summary>
        /// <param name="nmsString"></param>
        /// <returns></returns>
        public static string GetText(INMSString nmsString) => nmsString.StringValue();


        /// <summary>
        /// Creates the shortest NMSString that will fit this string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static INMSString CreateFrom(string text)
        {
            return CreateFrom(text, text.Length);
        }

        /// <summary>
        /// Creates a nms string along with the provided max length.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static INMSString CreateFrom(string text, int maxLength)
        {
            if (text == null)
                return null;

            KeyValuePair<int, Type> closestString = strings.First();
            foreach (var stringType in strings)
            {
                if (stringType.Key - maxLength < 0)
                    continue;

                if (stringType.Key - maxLength < closestString.Key)
                    closestString = stringType;
            }

            // create string and set text.
            return CreateFrom(closestString.Value, text);
        }

        /// <summary>
        /// Creates a NMSString from the provided type and sets it's text.
        /// </summary>
        /// <param name="stringType"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static INMSString CreateFrom(Type stringType, string text)
        {
            var nmsString = Activator.CreateInstance(stringType);
            var valueField = nmsString.GetType().GetField(nameof(NMSString0x10.Value));
            valueField.SetValue(nmsString, text);
            return (INMSString)nmsString;
        }
    }
}
