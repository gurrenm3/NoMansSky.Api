using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationDescriptorGroups : NMSTemplate
{
	public VirtualList<GcCustomisationDescriptorGroup> DescriptorGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationDescriptorGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationDescriptorGroup>(value);
	}

	public GcCustomisationDescriptorGroups(long address) : base(address)
	{

	}
}
