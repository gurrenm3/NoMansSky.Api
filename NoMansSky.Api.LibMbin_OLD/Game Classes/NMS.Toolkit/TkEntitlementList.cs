using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEntitlementList : NMSTemplate
{
	public VirtualList<TkEntitlementListData> Entitlements
	{
		get => cache.GetOrAddValue(new VirtualList<TkEntitlementListData>(address + GetOffset()));
		set => TrySetValue<TkEntitlementListData>(value);
	}

	public TkEntitlementList(long address) : base(address)
	{

	}
}
