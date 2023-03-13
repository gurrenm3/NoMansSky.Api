using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableItemTreeNode : NMSTemplate
{
	public NMSString0x10 Unlockable
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcUnlockableItemTreeNode> Children
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockableItemTreeNode>(address + GetOffset()));
		set => TrySetValue<GcUnlockableItemTreeNode>(value);
	}

	public GcUnlockableItemTreeNode(long address) : base(address)
	{

	}
}
