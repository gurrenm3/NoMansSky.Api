using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUniverseAddressData : NMSTemplate
{
	public Int32 RealityIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcGalacticAddressData GalacticAddress
	{
		get => GetValue<GcGalacticAddressData>();
		set => TrySetValue<GcGalacticAddressData>(value);
	}

	public GcUniverseAddressData(long address) : base(address)
	{

	}
}
