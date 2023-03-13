using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasDiscoveryData : NMSTemplate
{
	public GcUniverseAddressData UniverseAddress
	{
		get => GetValue<GcUniverseAddressData>();
		set => TrySetValue<GcUniverseAddressData>(value);
	}

	public GcDiscoveryType Type
	{
		get => GetValue<GcDiscoveryType>();
		set => TrySetValue<GcDiscoveryType>(value);
	}

	public Int32 PayloadElements
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<UInt64> Payload
	{
		get => cache.GetOrAddValue(new VirtualArray<UInt64>(address + GetOffset(), 5));
		set => TrySetValue<UInt64>(value);
	}

	public GcAtlasDiscoveryData(long address) : base(address)
	{

	}
}
