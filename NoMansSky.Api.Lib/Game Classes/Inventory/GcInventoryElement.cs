using System.Runtime.InteropServices;

namespace NoMansSky.Api
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct GcInventoryElement
    {
        [FieldOffset(0x0)]
        public GcInventoryType type;

        [FieldOffset(0x8)]
        public char* id;

        [FieldOffset(0x18)]
        public int amount;

        [FieldOffset(0x1C)]
        public int maxAmount;

        [FieldOffset(0x28)]
        public GcInventoryIndex index;
    }
}
