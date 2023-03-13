using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWikiCategory : NMSTemplate
{
	public NMSString0x20A CategoryID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A CategoryIDUpper
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkTextureResource IconOn
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource IconOff
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualList<GcWikiTopic> Topics
	{
		get => cache.GetOrAddValue(new VirtualList<GcWikiTopic>(address + GetOffset()));
		set => TrySetValue<GcWikiTopic>(value);
	}

	public GcWikiTopicType Type
	{
		get => GetValue<GcWikiTopicType>();
		set => TrySetValue<GcWikiTopicType>(value);
	}

	public VirtualList<NMSString0x10> Items
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 UnseenCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 UnlockedCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcWikiCategory(long address) : base(address)
	{

	}
}
