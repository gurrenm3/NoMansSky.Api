using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomInventoryComponentData : NMSTemplate
{
	public NMSString0x10 Size
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcInventoryTechProbability> DesiredTechs
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryTechProbability>(address + GetOffset()));
		set => TrySetValue<GcInventoryTechProbability>(value);
	}

	public Boolean Cool
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCustomInventoryComponentData(long address) : base(address)
	{

	}
}
