using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardOpenUnlockTree : NMSTemplate
{
	public GcUnlockableItemTreeGroups TreeToOpen
	{
		get => GetValue<GcUnlockableItemTreeGroups>();
		set => TrySetValue<GcUnlockableItemTreeGroups>(value);
	}

	public Int32 PageIndexOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardOpenUnlockTree(long address) : base(address)
	{

	}
}
