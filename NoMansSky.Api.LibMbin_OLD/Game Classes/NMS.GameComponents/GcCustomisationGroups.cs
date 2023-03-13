using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationGroups : NMSTemplate
{
	public VirtualList<GcCustomisationGroup> CustomisationGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationGroup>(value);
	}

	public GcCustomisationGroups(long address) : base(address)
	{

	}
}
