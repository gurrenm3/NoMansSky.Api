using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherColourModifiers : NMSTemplate
{
	public GcColourModifier SkyColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier SkyUpperColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier HorizonColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier SunColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier FogColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier HeightFogColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier LightColour
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier CloudColour1
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcColourModifier CloudColour2
	{
		get => GetValue<GcColourModifier>();
		set => TrySetValue<GcColourModifier>(value);
	}

	public VirtualArray<GcColourModifier> HeavyAirColour
	{
		get => cache.GetOrAddValue(new VirtualArray<GcColourModifier>(address + GetOffset(), 5));
		set => TrySetValue<GcColourModifier>(value);
	}

	public GcWeatherColourModifiers(long address) : base(address)
	{

	}
}
