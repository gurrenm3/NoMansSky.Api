using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableItemTreeGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcUnlockableItemTreeGroups.UnlockableItemTreeEnum UnlockableItemTree
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUnlockableItemTreeGroups.UnlockableItemTreeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUnlockableItemTreeGroups.UnlockableItemTreeEnum>(value);
	}

	public GcUnlockableItemTreeGroups(long address) : base(address)
	{

	}
}
