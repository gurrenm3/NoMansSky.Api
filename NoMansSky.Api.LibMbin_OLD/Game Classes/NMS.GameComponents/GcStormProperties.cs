using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStormProperties : NMSTemplate
{
	public Single Weighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFogProperties Fog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcWeatherColourModifiers ColourModifiers
	{
		get => GetValue<GcWeatherColourModifiers>();
		set => TrySetValue<GcWeatherColourModifiers>(value);
	}

	public VirtualArray<Vector2f> HazardModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector2f>(address + GetOffset(), 5));
		set => TrySetValue<Vector2f>(value);
	}

	public GcStormProperties(long address) : base(address)
	{

	}
}
