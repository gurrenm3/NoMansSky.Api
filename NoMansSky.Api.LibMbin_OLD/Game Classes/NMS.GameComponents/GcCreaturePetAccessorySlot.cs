using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetAccessorySlot : NMSTemplate
{
	public NMSString0x100 AttachLocator
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x10 AccessoryGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreaturePetAccessorySlot(long address) : base(address)
	{

	}
}
