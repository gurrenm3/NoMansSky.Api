using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardValueInteger : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Value
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkBlackboardValueInteger(long address) : base(address)
	{

	}
}
