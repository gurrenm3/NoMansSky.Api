using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetAccessoryGroup : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcPetAccessoryType> DisallowedAccessories
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetAccessoryType>(address + GetOffset()));
		set => TrySetValue<GcPetAccessoryType>(value);
	}

	public GcPetAccessoryGroup(long address) : base(address)
	{

	}
}
