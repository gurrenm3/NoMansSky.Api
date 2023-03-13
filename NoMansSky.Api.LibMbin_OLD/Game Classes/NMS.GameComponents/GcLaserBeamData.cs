using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLaserBeamData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 BeamFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 BeamCoreFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EndTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudioWwiseEvents AudioStart
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents AudioStop
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents AudioOverheat
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
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

	public Single CriticalHitModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 PlayerDamage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ImpactEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcProjectileImpactData> Impacts
	{
		get => cache.GetOrAddValue(new VirtualList<GcProjectileImpactData>(address + GetOffset()));
		set => TrySetValue<GcProjectileImpactData>(value);
	}

	public Single HitRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SingleHit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public Single MiningHitRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HasLight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanMine
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyCombatLevelMultipliers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PiercingDamagePercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
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

	public VirtualList<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers
	{
		get => cache.GetOrAddValue(new VirtualList<GcCombatEffectDamageMultiplier>(address + GetOffset()));
		set => TrySetValue<GcCombatEffectDamageMultiplier>(value);
	}

	public GcLaserBeamData(long address) : base(address)
	{

	}
}
