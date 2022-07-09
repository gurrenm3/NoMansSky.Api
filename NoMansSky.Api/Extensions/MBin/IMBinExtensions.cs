namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IMBin"/>.
    /// </summary>
    public static class IMBinExtensions
    {
        /// <summary>
        /// Returns whether or not this mbin is representing a globals file.
        /// </summary>
        /// <param name="mbin"></param>
        /// <returns></returns>
        public static bool IsGlobalMbin(this IMBin mbin)
        {
            return mbin.MBinName.EndsWith("Globals");
        }
    }
}
