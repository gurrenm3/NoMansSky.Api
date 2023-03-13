using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryPage : NMSTemplate
{
	public GcInteractionType InteractionType
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean StatIsBitmask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public NMSString0x20A ID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcStoryEntry> Entries
	{
		get => cache.GetOrAddValue(new VirtualList<GcStoryEntry>(address + GetOffset()));
		set => TrySetValue<GcStoryEntry>(value);
	}

	public Boolean UseGridType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcWikiTopicType WikiGridType
	{
		get => GetValue<GcWikiTopicType>();
		set => TrySetValue<GcWikiTopicType>(value);
	}

	public GcStoryPage(long address) : base(address)
	{

	}
}
