using System.Runtime.InteropServices;

namespace NoMansSky.Api.libMBIN;

[StructLayout(LayoutKind.Explicit, Size = 0x383)]
public unsafe partial struct GcPlanetInfo
{

    [FieldOffset(0x0)] public NMSString0x80 planetDescription;

    [FieldOffset(0x80)] public NMSString0x80 planetType;

    [FieldOffset(0x100)] public NMSString0x80 weather;

    [FieldOffset(0x180)] public NMSString0x80 resources;

    [FieldOffset(0x200)] public NMSString0x80 flora;

    [FieldOffset(0x280)] public NMSString0x80 fauna;

    [FieldOffset(0x300)] public NMSString0x80 sentinels;

    [FieldOffset(0x380)] public bool isWeatherExtreme;

    [FieldOffset(0x381)] public bool areSentinelsExtreme;

    [FieldOffset(0x382)] public bool areSentinelsModerate;
}
