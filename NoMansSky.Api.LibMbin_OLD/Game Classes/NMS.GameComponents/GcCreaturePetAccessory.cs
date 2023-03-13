using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetAccessory : NMSTemplate
{
	public NMSString0x20A RequiredDescriptor
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcCreaturePetAccessorySlot> Slots
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreaturePetAccessorySlot>(address + GetOffset()));
		set => TrySetValue<GcCreaturePetAccessorySlot>(value);
	}

	public VirtualList<NMSString0x20A> HideParts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCreaturePetAccessory(long address) : base(address)
	{

	}
}
