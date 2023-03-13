using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardDefaultValueId : NMSTemplate
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

	public NMSString0x10 DefaultValue
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueId(long address) : base(address)
	{

	}
}
