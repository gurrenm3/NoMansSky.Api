using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationRace : NMSTemplate
{
	public NMSString0x10 DescriptorGroupOption
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IsGek
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCustomisationGroup> CustomisationGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationGroup>(value);
	}

	public VirtualList<NMSString0x10> Presets
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCustomisationRace(long address) : base(address)
	{

	}
}
