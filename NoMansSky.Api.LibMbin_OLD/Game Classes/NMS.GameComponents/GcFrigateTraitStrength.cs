using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateTraitStrength : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFrigateTraitStrength.FrigateTraitStrengthEnum FrigateTraitStrength
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFrigateTraitStrength.FrigateTraitStrengthEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFrigateTraitStrength.FrigateTraitStrengthEnum>(value);
	}

	public GcFrigateTraitStrength(long address) : base(address)
	{

	}
}
