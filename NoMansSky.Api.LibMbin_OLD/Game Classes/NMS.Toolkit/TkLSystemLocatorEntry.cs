using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemLocatorEntry : NMSTemplate
{
	public NMSString0x80 Model
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<TkLSystemRestrictionData> Restrictions
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemRestrictionData>(address + GetOffset()));
		set => TrySetValue<TkLSystemRestrictionData>(value);
	}

	public TkLSystemLocatorEntry(long address) : base(address)
	{

	}
}
