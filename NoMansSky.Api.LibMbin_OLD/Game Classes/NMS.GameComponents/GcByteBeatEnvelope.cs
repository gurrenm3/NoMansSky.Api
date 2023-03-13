using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatEnvelope : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcByteBeatEnvelope.ByteBeatEnvelopeEnum ByteBeatEnvelope
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcByteBeatEnvelope.ByteBeatEnvelopeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcByteBeatEnvelope.ByteBeatEnvelopeEnum>(value);
	}

	public GcByteBeatEnvelope(long address) : base(address)
	{

	}
}
