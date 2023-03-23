using System.Runtime.InteropServices;

namespace NoMansSky.Api.libMBIN;

[StructLayout(LayoutKind.Explicit, Size = 0x4)]
public unsafe partial struct GcPlanetLife
{

    [FieldOffset(0x0)] public int lifeSetting;
}
