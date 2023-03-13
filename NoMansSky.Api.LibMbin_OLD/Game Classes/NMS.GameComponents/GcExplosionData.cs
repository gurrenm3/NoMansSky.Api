using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExplosionData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkModelResource Model
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public VirtualList<GcDebrisData> Debris
	{
		get => cache.GetOrAddValue(new VirtualList<GcDebrisData>(address + GetOffset()));
		set => TrySetValue<GcDebrisData>(value);
	}

	public Single Life
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CamShake
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CamShakeSpaceScale
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShakeStrengthModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 ShakeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllowTriggerActionOnDebris
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowShootableDebris
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowDestructableDebris
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MaxSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamShakeCustomMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcExplosionData(long address) : base(address)
	{

	}
}
