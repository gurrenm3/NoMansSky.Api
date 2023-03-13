using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetSectionData : NMSTemplate
{
	public UInt64 DiscovererUID
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<Byte> DiscovererPlatform
	{
		get => cache.GetOrAddValue(new VirtualArray<Byte>(address + GetOffset(), 2));
		set => TrySetValue<Byte>(value);
	}

	public Boolean DiscoveredState
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlanetSectionData(long address) : base(address)
	{

	}
}
