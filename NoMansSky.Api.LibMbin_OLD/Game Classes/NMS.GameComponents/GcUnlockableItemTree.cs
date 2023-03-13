using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableItemTree : NMSTemplate
{
	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 CostTypeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcUnlockableItemTreeNode Root
	{
		get => GetValue<GcUnlockableItemTreeNode>();
		set => TrySetValue<GcUnlockableItemTreeNode>(value);
	}

	public GcUnlockableItemTree(long address) : base(address)
	{

	}
}
