using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableItemTrees : NMSTemplate
{
	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcUnlockableItemTree> Trees
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockableItemTree>(address + GetOffset()));
		set => TrySetValue<GcUnlockableItemTree>(value);
	}

	public GcUnlockableItemTrees(long address) : base(address)
	{

	}
}
