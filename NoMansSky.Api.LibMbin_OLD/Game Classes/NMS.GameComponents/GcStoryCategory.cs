using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryCategory : NMSTemplate
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

	public VirtualList<GcStoryPage> Pages
	{
		get => cache.GetOrAddValue(new VirtualList<GcStoryPage>(address + GetOffset()));
		set => TrySetValue<GcStoryPage>(value);
	}

	public GcStoryCategory(long address) : base(address)
	{

	}
}
