using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDamageMultiplierLookup : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Default
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcDamageMultiplier> Multipliers
	{
		get => cache.GetOrAddValue(new VirtualList<GcDamageMultiplier>(address + GetOffset()));
		set => TrySetValue<GcDamageMultiplier>(value);
	}

	public GcDamageMultiplierLookup(long address) : base(address)
	{

	}
}
