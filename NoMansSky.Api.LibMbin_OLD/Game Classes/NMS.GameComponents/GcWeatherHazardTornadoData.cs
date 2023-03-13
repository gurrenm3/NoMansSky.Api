using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherHazardTornadoData : NMSTemplate
{
	public Single SuckInRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuckInStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuckUpRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuckUpStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuckUpHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuckUpHeightCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWeatherHazardTornadoData(long address) : base(address)
	{

	}
}
