using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingFilename : NMSTemplate
{
	public VirtualArray<NMSString0x80> LSystem
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<NMSString0x80> Scene
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<NMSString0x80> WFC
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcBuildingFilename(long address) : base(address)
	{

	}
}
