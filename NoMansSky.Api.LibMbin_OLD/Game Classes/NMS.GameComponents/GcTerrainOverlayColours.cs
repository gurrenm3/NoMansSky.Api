using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainOverlayColours : NMSTemplate
{
	public Single Cutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlightStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulsePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTerrainOverlayColours(long address) : base(address)
	{

	}
}
