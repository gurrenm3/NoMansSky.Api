using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectileData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcResourceElement Model
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcAudioWwiseEvents FireAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents ChargedFireAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents OverheatAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean IsAutonomous
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyCombatLevelMultipliers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CapsuleHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Gravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Life
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollPush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhysicsPush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DefaultDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ExtraPlayerDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDamageType DamageType
	{
		get => GetValue<GcDamageType>();
		set => TrySetValue<GcDamageType>(value);
	}

	public Int32 DefaultBounces
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BounceMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BounceDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BounceFinalStopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HitOnBounce
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 PlayerDamage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CriticalHitModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PiercingDamagePercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseCustomBulletData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcProjectileLineData CustomBulletData
	{
		get => GetValue<GcProjectileLineData>();
		set => TrySetValue<GcProjectileLineData>(value);
	}

	public Boolean UseDamageNumberData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DamageImpactMergeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageImpactTimeBetweenNumbers
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageImpactMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean OverrideLightColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.GameComponents.GcProjectileData.BehaviourFlagsEnum BehaviourFlags
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProjectileData.BehaviourFlagsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProjectileData.BehaviourFlagsEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcProjectileData.ClassEnum Class
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProjectileData.ClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProjectileData.ClassEnum>(value);
	}

	public NMSString0x10 DefaultImpact
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CriticalImpact
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcProjectileImpactData> Impacts
	{
		get => cache.GetOrAddValue(new VirtualList<GcProjectileImpactData>(address + GetOffset()));
		set => TrySetValue<GcProjectileImpactData>(value);
	}

	public Vector3f ImpactOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<GcImpactCombatEffectData> CombatEffectsOnImpact
	{
		get => cache.GetOrAddValue(new VirtualList<GcImpactCombatEffectData>(address + GetOffset()));
		set => TrySetValue<GcImpactCombatEffectData>(value);
	}

	public GcProjectileData(long address) : base(address)
	{

	}
}
