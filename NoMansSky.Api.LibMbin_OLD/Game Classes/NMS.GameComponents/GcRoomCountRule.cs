using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRoomCountRule : NMSTemplate
{
	public NMSString0x10 RoomID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Min
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Max
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRoomCountRule(long address) : base(address)
	{

	}
}
