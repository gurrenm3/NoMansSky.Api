using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatEffectDamageMultiplier : NMSTemplate
{
	public GcCombatEffectType CombatEffectType
	{
		get => GetValue<GcCombatEffectType>();
		set => TrySetValue<GcCombatEffectType>(value);
	}

	public Single DamageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCombatEffectDamageMultiplier(long address) : base(address)
	{

	}
}
