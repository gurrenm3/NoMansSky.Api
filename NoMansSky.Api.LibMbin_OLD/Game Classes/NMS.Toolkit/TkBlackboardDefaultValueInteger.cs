using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardDefaultValueInteger : NMSTemplate
{
	public TkBlackboardCategory BlackboardCategory
	{
		get => GetValue<TkBlackboardCategory>();
		set => TrySetValue<TkBlackboardCategory>(value);
	}

	public NMSString0x10 BlackboardKey
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 DefaultValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkBlackboardDefaultValueInteger(long address) : base(address)
	{

	}
}
