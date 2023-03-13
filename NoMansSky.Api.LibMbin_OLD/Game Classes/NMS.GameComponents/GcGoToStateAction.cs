using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGoToStateAction : NMSTemplate
{
	public NMSString0x10 State
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Broadcast
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBroadcastLevel BroadcastLevel
	{
		get => GetValue<GcBroadcastLevel>();
		set => TrySetValue<GcBroadcastLevel>(value);
	}

	public GcGoToStateAction(long address) : base(address)
	{

	}
}
