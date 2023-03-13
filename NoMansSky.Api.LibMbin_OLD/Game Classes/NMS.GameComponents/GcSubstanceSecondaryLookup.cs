using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSubstanceSecondaryLookup : NMSTemplate
{
	public NMSString0x10 PrimaryID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcSubstanceSecondary> SecondaryChances
	{
		get => cache.GetOrAddValue(new VirtualList<GcSubstanceSecondary>(address + GetOffset()));
		set => TrySetValue<GcSubstanceSecondary>(value);
	}

	public GcSubstanceSecondaryLookup(long address) : base(address)
	{

	}
}
