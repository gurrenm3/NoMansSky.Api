using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerWeaponPropertiesData : NMSTemplate
{
	public GcPlayerWeaponClass WeaponClass
	{
		get => GetValue<GcPlayerWeaponClass>();
		set => TrySetValue<GcPlayerWeaponClass>(value);
	}

	public GcStatsTypes Stat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public GcRemoteWeapons RemoteType
	{
		get => GetValue<GcRemoteWeapons>();
		set => TrySetValue<GcRemoteWeapons>(value);
	}

	public NMSString0x80 MuzzleLaserResource
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 MuzzleGunResource
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 DefaultProjectile
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleIdleAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleFireAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleChargedAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleIdleParticlesId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleFireParticlesId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultMuzzleChargedParticlesId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultWeaponIdleAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultWeaponFireAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultWeaponChargedAnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DefaultWeaponFireParticlesId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MuzzleFlashScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChargingMuzzleFlashMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChargingMuzzleFlashMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VibrationScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RumbleScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticlesOffsetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 VibartionId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ShakeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean UseMuzzleLight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MuzzleLightUsesLaserColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MuzzleLightUsesMuzzleColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour DefaultMuzzleLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single MuzzleLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FlashMuzzleOnProjectileFire
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeAnims
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeMuzzleParticles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeProjectile
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeFireAnims
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeFireParticles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesCustomBiomeStats
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcPlayerWeaponBiomeProperties> BiomeProperties
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerWeaponBiomeProperties>(address + GetOffset()));
		set => TrySetValue<GcPlayerWeaponBiomeProperties>(value);
	}

	public GcPlayerWeaponPropertiesData(long address) : base(address)
	{

	}
}
