using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatEffectType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCombatEffectType.CombatEffectTypeEnum CombatEffectType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCombatEffectType.CombatEffectTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCombatEffectType.CombatEffectTypeEnum>(value);
	}

	public GcCombatEffectType(long address) : base(address)
	{

	}
}
