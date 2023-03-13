using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetHeavyAirData : NMSTemplate
{
	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<GcHeavyAirColourData> Colours
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHeavyAirColourData>(address + GetOffset(), 5));
		set => TrySetValue<GcHeavyAirColourData>(value);
	}

	public GcPlanetHeavyAirData(long address) : base(address)
	{

	}
}
