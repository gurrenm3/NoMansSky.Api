using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherTable : NMSTemplate
{
	public VirtualArray<NMSString0x80> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<GcHazardValues> DefaultTemperature
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public VirtualArray<GcHazardValues> DefaultToxicity
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public VirtualArray<GcHazardValues> DefaultRadiation
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHazardValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHazardValues>(value);
	}

	public GcWeatherTable(long address) : base(address)
	{

	}
}
