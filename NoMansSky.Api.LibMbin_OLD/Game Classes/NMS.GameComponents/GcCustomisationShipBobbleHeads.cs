using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationShipBobbleHeads : NMSTemplate
{
	public VirtualList<GcCustomisationBobbleHead> BobbleHeads
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationBobbleHead>(address + GetOffset()));
		set => TrySetValue<GcCustomisationBobbleHead>(value);
	}

	public GcCustomisationShipBobbleHeads(long address) : base(address)
	{

	}
}
