using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for IMbinManager.
    /// </summary>
    public static class IMBinManagerExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Provides an easier way to mod an Mbin.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbinManager"></param>
        /// <param name="modify"></param>
        public static void ModifyMbin<T>(this IMBinManager mbinManager, Action<T> modify)
        {
            string mbinName = nameof(T);
            var mbin = mbinManager.GetMbin(mbinName);
            if (mbin == null)
            {
                ConsoleUtil.LogError($"Can't modify mbin. Tried getting Mbin by it's type but failed." +
                    $" This usually means that this type of Mbin is not yet managed by the API.");
                return;
            }

            var mbinObject = memory.GetValue<T>(mbin.Address);
            modify.Invoke(mbinObject);
            memory.SetValue(mbin.Address, mbinObject);
        }


        /// <summary>
        /// Provides an easier way to mod an Mbin.
        /// </summary>
        /// <param name="mbinManager"></param>
        /// <param name="mbinAddress"></param>
        /// <param name="modify"></param>
        public static void ModifyMbin<T>(this IMBinManager mbinManager, long mbinAddress, Action<T> modify)
        {
            if (mbinAddress <= 0)
            {
                ConsoleUtil.LogError($"Can't modify mbin. MbinAddress is invald!");
                return;
            }

            var mbinObject = memory.GetValue<T>(mbinAddress);
            modify.Invoke(mbinObject);
            memory.SetValue(mbinAddress, mbinObject);
        }
    }
}
