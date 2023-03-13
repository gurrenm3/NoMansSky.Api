using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageProjectileImpact : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Damage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcDamageType Type
	{
		get => GetValue<GcDamageType>();
		set => TrySetValue<GcDamageType>(value);
	}

	public Boolean Critical
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Ineffective
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LaserHeatBoost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNodeID Node
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public libMBIN.NMS.GameComponents.GcMessageProjectileImpact.HitTypeEnum HitType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMessageProjectileImpact.HitTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMessageProjectileImpact.HitTypeEnum>(value);
	}

	public Vector3f PosLocal
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f PosOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<GcImpactCombatEffectData> CombatEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcImpactCombatEffectData>(address + GetOffset()));
		set => TrySetValue<GcImpactCombatEffectData>(value);
	}

	public VirtualList<GcCombatEffectDamageMultiplier> DamageMultipliers
	{
		get => cache.GetOrAddValue(new VirtualList<GcCombatEffectDamageMultiplier>(address + GetOffset()));
		set => TrySetValue<GcCombatEffectDamageMultiplier>(value);
	}

	public GcMessageProjectileImpact(long address) : base(address)
	{

	}
}
