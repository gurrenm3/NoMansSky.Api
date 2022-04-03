using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct GcPlayerStateData
    {
        /// <summary>
        /// Unknown value.
        /// </summary>
        [FieldOffset(0x0)]
        public ulong* value0;
    }
}