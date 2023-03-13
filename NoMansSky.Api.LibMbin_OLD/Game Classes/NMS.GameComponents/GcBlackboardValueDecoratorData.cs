using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlackboardValueDecoratorData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ClearOnSuccess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSTemplate Child
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcBlackboardValueDecoratorData(long address) : base(address)
	{

	}
}
