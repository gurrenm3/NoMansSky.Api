﻿using libMBIN;
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
        public static void ModifyMBin<T>(this IMBinManager mbinManager, Action<T> modify) where T : NMSTemplate
        {
            string mbinName = nameof(T);
            var mbin = mbinManager.GetMBin(mbinName);
            if (mbin == null)
            {
                ConsoleUtils.WriteError($"Can't modify mbin. Tried getting Mbin by it's type but failed." +
                    $" This usually means that this type of Mbin is not yet managed by the API.");
                return;
            }

            mbin.Modify(modify);
        }

        /// <summary>
        /// Provides an easier way to mod an Mbin.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbinManager"></param>
        /// <param name="modify"></param>
        /// <returns></returns>
        public static async Task ModifyMBinAsync<T>(this IMBinManager mbinManager, Action<T> modify) where T : NMSTemplate
        {
            await Task.Run(() =>
            {
                string mbinName = nameof(T);
                var mbin = mbinManager.GetMBin(mbinName);
                if (mbin == null)
                {
                    ConsoleUtils.WriteError($"Can't modify mbin. Tried getting Mbin by it's type but failed." +
                        $" This usually means that this type of Mbin is not yet managed by the API.");
                    return;
                }

                mbin.Modify(modify);
            });
        }


        /// <summary>
        /// Provides an easier way to mod an Mbin. Takes MBin address as a parameter and lets you modify it.
        /// </summary>
        /// <param name="mbinManager"></param>
        /// <param name="mbinAddress"></param>
        /// <param name="modify"></param>
        public static void ModifyMBin<T>(this IMBinManager mbinManager, long mbinAddress, Action<T> modify) where T : NMSTemplate
        {
            if (mbinAddress <= 0)
            {
                ConsoleUtils.WriteError($"Can't modify mbin. MbinAddress is invald!");
                return;
            }

            var mbinObject = memory.GetValue<T>(mbinAddress);
            modify.Invoke(mbinObject);
            memory.SetValue(mbinAddress, mbinObject);
        }

        /// <summary>
        /// Provides an easier way to mod an Mbin. Takes MBin address as a parameter and lets you modify it.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbinManager"></param>
        /// <param name="mbinAddress"></param>
        /// <param name="modify"></param>
        /// <returns></returns>
        public static async Task ModifyMBinAsync<T>(this IMBinManager mbinManager, long mbinAddress, Action<T> modify) where T : NMSTemplate
        {
            await Task.Run(() =>
            {
                if (mbinAddress <= 0)
                {
                    ConsoleUtils.WriteError($"Can't modify mbin. MbinAddress is invald!");
                    return;
                }

                var mbinObject = memory.GetValue<T>(mbinAddress);
                modify.Invoke(mbinObject);
                memory.SetValue(mbinAddress, mbinObject);
            });
        }

        /// <summary>
        /// Provides an easier way to mod an Mbin. Takes an mbin name as a parameter and lets you modify the corresponding mbin if it's being managed.
        /// </summary>
        /// <param name="mbinManager"></param>
        /// <param name="mbinName"></param>
        /// <param name="modify"></param>
        /// <param name="useFullName">Whether or not to search using the full mbin name.</param>
        public static void ModifyMBin<T>(this IMBinManager mbinManager, string mbinName, Action<T> modify, bool useFullName = false) where T : NMSTemplate
        {
            if (String.IsNullOrEmpty(mbinName))
            {
                ConsoleUtils.WriteError($"Can't modify mbin. mbinName is invald!");
                return;
            }

            var mbin = mbinManager.GetMBin(mbinName, useFullName);
            if (mbin == null)
            {
                ConsoleUtils.WriteError($"Can't modify mbin. Failed to get mbin by name!");
                return;
            }

            mbin.Modify(modify);
        }

        /// <summary>
        /// Provides an easier way to mod an Mbin. Takes an mbin name as a parameter and lets you modify the corresponding mbin if it's being managed.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="mbinManager"></param>
        /// <param name="mbinName"></param>
        /// <param name="modify"></param>
        /// <param name="useFullName">Whether or not to search using the full mbin name.</param>
        public static async Task ModifyMBinAsync<T>(this IMBinManager mbinManager, string mbinName, Action<T> modify, bool useFullName = false) where T : NMSTemplate
        {
            await Task.Run(() =>
            {
                if (String.IsNullOrEmpty(mbinName))
                {
                    ConsoleUtils.WriteError($"Can't modify mbin. mbinName is invald!");
                    return;
                }

                var mbin = mbinManager.GetMBin(mbinName, useFullName);
                if (mbin == null)
                {
                    ConsoleUtils.WriteError($"Can't modify mbin. Failed to get mbin by name!");
                    return;
                }

                mbin.Modify(modify);
            });
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
