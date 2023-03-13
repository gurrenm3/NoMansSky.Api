using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLegality : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcLegality.LegalityEnum Legality
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcLegality.LegalityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcLegality.LegalityEnum>(value);
	}

	public GcLegality(long address) : base(address)
	{

	}
}
