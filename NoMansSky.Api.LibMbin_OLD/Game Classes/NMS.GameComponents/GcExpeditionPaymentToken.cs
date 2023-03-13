using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionPaymentToken : NMSTemplate
{
	public NMSString0x10 TokenName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 TokenValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionPaymentToken(long address) : base(address)
	{

	}
}
