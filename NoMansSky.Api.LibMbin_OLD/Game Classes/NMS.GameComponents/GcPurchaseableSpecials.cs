using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPurchaseableSpecials : NMSTemplate
{
	public VirtualList<GcPurchaseableSpecial> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcPurchaseableSpecial>(address + GetOffset()));
		set => TrySetValue<GcPurchaseableSpecial>(value);
	}

	public GcPurchaseableSpecials(long address) : base(address)
	{

	}
}
