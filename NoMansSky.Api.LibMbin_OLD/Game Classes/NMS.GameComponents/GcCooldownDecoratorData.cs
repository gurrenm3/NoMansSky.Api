using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCooldownDecoratorData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueFloat CooldownTime
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public NMSTemplate Child
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcCooldownDecoratorData(long address) : base(address)
	{

	}
}
