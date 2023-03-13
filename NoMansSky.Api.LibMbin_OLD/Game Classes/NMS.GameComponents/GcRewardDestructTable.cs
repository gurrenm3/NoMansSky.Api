using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDestructTable : NMSTemplate
{
	public VirtualArray<GcRewardDestructRarities> Categories
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRewardDestructRarities>(address + GetOffset(), 9));
		set => TrySetValue<GcRewardDestructRarities>(value);
	}

	public GcRewardDestructTable(long address) : base(address)
	{

	}
}
