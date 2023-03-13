using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcImpactCombatEffectData : NMSTemplate
{
	public GcCombatEffectType CombatEffectType
	{
		get => GetValue<GcCombatEffectType>();
		set => TrySetValue<GcCombatEffectType>(value);
	}

	public Single TotalDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamagePerSeccond
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CurrentDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcImpactCombatEffectData(long address) : base(address)
	{

	}
}
