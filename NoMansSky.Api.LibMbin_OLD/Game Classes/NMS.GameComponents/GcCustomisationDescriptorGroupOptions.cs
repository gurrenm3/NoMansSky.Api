using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationDescriptorGroupOptions : NMSTemplate
{
	public NMSString0x20A GroupTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean FirstOptionIsEmpty
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationDescriptorGroupOption>(address + GetOffset()));
		set => TrySetValue<GcCustomisationDescriptorGroupOption>(value);
	}

	public VirtualList<NMSString0x10> PrerequisiteGroup
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCustomisationDescriptorGroupOptions(long address) : base(address)
	{

	}
}
