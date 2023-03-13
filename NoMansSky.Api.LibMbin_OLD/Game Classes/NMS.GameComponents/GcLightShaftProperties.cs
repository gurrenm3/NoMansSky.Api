using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLightShaftProperties : NMSTemplate
{
	public Single LightShaftScattering
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightShaftStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightShaftBottom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightShaftTop
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LightShaftColourBottom
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour LightShaftColourTop
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcLightShaftProperties(long address) : base(address)
	{

	}
}
