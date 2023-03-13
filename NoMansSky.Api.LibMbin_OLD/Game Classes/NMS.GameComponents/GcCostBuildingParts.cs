using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostBuildingParts : NMSTemplate
{
	public NMSString0x20A Description
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcBuildingCostPartCount> RequiredParts
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingCostPartCount>(address + GetOffset()));
		set => TrySetValue<GcBuildingCostPartCount>(value);
	}

	public GcCostBuildingParts(long address) : base(address)
	{

	}
}
