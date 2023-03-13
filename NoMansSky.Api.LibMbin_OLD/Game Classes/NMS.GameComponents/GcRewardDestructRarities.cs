using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDestructRarities : NMSTemplate
{
	public VirtualArray<GcRewardDestructEntry> Rarities
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRewardDestructEntry>(address + GetOffset(), 3));
		set => TrySetValue<GcRewardDestructEntry>(value);
	}

	public GcRewardDestructRarities(long address) : base(address)
	{

	}
}
