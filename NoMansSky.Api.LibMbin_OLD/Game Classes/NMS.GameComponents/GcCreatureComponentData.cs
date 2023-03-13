using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureComponentData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPrimaryAxis Axis
	{
		get => GetValue<GcPrimaryAxis>();
		set => TrySetValue<GcPrimaryAxis>(value);
	}

	public Single Scaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetIndoorScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DeathEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcReplacementEffectData> ReplacementImpacts
	{
		get => cache.GetOrAddValue(new VirtualList<GcReplacementEffectData>(address + GetOffset()));
		set => TrySetValue<GcReplacementEffectData>(value);
	}

	public Single AccessoryPitchOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DiscoveryFurScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DiscoveryUIScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f DiscoveryUIOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<GcCreatureDiscoveryThumbnailOverride> ThumbnailOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureDiscoveryThumbnailOverride>(address + GetOffset()));
		set => TrySetValue<GcCreatureDiscoveryThumbnailOverride>(value);
	}

	public Boolean UsePetLargeUIOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetLargeUIOverrideScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f PetLargeUIOverrideOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcCreatureComponentData(long address) : base(address)
	{

	}
}
