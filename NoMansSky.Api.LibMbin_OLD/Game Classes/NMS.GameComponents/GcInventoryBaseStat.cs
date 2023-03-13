using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryBaseStat : NMSTemplate
{
	public NMSString0x10 BaseStatID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LocID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcInventoryBaseStatBonus> StatBonus
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryBaseStatBonus>(address + GetOffset()));
		set => TrySetValue<GcInventoryBaseStatBonus>(value);
	}

	public GcInventoryBaseStat(long address) : base(address)
	{

	}
}
