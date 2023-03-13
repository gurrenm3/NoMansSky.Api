using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionBaseBuildingState : NMSTemplate
{
	public NMSString0x10 TriggerAction
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Time
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInteractionBaseBuildingState(long address) : base(address)
	{

	}
}
