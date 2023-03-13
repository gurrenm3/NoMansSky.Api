using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryEntry : NMSTemplate
{
	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Entry
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcStoryEntryBranch> BranchedEntries
	{
		get => cache.GetOrAddValue(new VirtualList<GcStoryEntryBranch>(address + GetOffset()));
		set => TrySetValue<GcStoryEntryBranch>(value);
	}

	public NMSString0x20A AlienText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean AutoPrefixWithAlienText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcStoryEntry(long address) : base(address)
	{

	}
}
