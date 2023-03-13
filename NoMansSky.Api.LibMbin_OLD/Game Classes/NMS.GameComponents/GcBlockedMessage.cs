using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlockedMessage : NMSTemplate
{
	public NMSString0x80 MessageId
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcBlockedMessage(long address) : base(address)
	{

	}
}
