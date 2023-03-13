using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherHazardLightningData : NMSTemplate
{
	public TkModelResource IndicatorDecal
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource StaticDecal
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Single MinRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DecalFullGrowthProgress
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NumFlashes
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashStartProgress
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EarliestImpact
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EarliestImpactFirstInstance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinStrikes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxStrikes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 ShakeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ImpactParticle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DamageID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single FullDamageRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWeatherHazardLightningData(long address) : base(address)
	{

	}
}
