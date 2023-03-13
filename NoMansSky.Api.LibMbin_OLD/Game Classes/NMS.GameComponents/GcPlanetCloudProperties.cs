using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetCloudProperties : NMSTemplate
{
	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Single Coverage1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Coverage2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Coverage3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f CoverExtremes
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single Ratio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RateOfChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SecondaryRateOfChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlanetCloudProperties.CloudinessEnum Cloudiness
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetCloudProperties.CloudinessEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetCloudProperties.CloudinessEnum>(value);
	}

	public GcPlanetCloudProperties(long address) : base(address)
	{

	}
}
