using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    [StructLayout(LayoutKind.Explicit)]
    public struct GcInventoryIndex
    {
        [FieldOffset(0x0)]
        public int x;

        [FieldOffset(0x4)]
        public int y;
    }
}
