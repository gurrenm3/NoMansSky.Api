using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationDescriptorGroup : NMSTemplate
{
	public NMSString0x10 GroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x80 Image
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<NMSString0x20> Descriptors
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> SuffixInclusionList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x10 LinkedSpecialID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Tip
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean HiddenInCustomiser
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCustomisationDescriptorGroup(long address) : base(address)
	{

	}
}
