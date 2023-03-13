using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHazardModifiers : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcHazardModifiers.HazardModifierEnum HazardModifier
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHazardModifiers.HazardModifierEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHazardModifiers.HazardModifierEnum>(value);
	}

	public GcHazardModifiers(long address) : base(address)
	{

	}
}
