using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDialogClearanceInfo : NMSTemplate
{
	public NMSString0x20A GlobalDialogID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 AssociatedMission
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcDialogClearanceInfo(long address) : base(address)
	{

	}
}
