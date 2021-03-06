using Reloaded.ModHelper;
using System;
using System.Threading.Tasks;

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
        public static void ModifyMBin<T>(this IMBinManager mbinManager, Action<T> modify)
        {
            string mbinName = nameof(T);
            var mbin = mbinManager.GetMBin(mbinName);
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
        public static void ModifyMBin<T>(this IMBinManager mbinManager, long mbinAddress, Action<T> modify)
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

        /// <summary>
        /// A high performance foreach loop that loops over all of the mbin files currently being managed.
        /// Multiple iterations will be run simultaneously.
        /// </summary>
        /// <param name="mBinManager"></param>
        /// <param name="foreachAction"></param>
        public static void ForEachMBin(this IMBinManager mBinManager, Action<IMBin> foreachAction)
        {
            Parallel.ForEach(mBinManager.GetAllMBin(), mbin =>
            {
                foreachAction?.Invoke(mbin);
            });
        }
    }
}
