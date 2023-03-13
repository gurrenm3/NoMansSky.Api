using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemGlobalRestriction : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 Model
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<TkLSystemRestrictionData> Restrictions
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemRestrictionData>(address + GetOffset()));
		set => TrySetValue<TkLSystemRestrictionData>(value);
	}

	public TkLSystemGlobalRestriction(long address) : base(address)
	{

	}
}
