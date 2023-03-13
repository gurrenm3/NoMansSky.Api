using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleFrequencyModifier : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum>(value);
	}

	public GcCreatureRoleFrequencyModifier(long address) : base(address)
	{

	}
}
