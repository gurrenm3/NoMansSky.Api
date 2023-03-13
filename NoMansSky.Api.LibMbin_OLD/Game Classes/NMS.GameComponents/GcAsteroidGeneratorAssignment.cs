using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidGeneratorAssignment : NMSTemplate
{
	public Int32 PlanetIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSolarSystemLocatorChoice Locator
	{
		get => GetValue<GcSolarSystemLocatorChoice>();
		set => TrySetValue<GcSolarSystemLocatorChoice>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Int32 AsteroidCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAsteroidGeneratorAssignment(long address) : base(address)
	{

	}
}
