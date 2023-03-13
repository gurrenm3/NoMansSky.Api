using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractionData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkAttachmentData Data
	{
		get => GetValue<TkAttachmentData>();
		set => TrySetValue<TkAttachmentData>(value);
	}

	public GcNPCInteractionData(long address) : base(address)
	{

	}
}
