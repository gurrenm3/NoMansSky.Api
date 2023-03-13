using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidSystemGenerationData : NMSTemplate
{
	public GcAsteroidGenerationData CommonAsteroidData
	{
		get => GetValue<GcAsteroidGenerationData>();
		set => TrySetValue<GcAsteroidGenerationData>(value);
	}

	public GcAsteroidGenerationData RingAsteroidData
	{
		get => GetValue<GcAsteroidGenerationData>();
		set => TrySetValue<GcAsteroidGenerationData>(value);
	}

	public GcAsteroidGenerationData LargeAsteroidData
	{
		get => GetValue<GcAsteroidGenerationData>();
		set => TrySetValue<GcAsteroidGenerationData>(value);
	}

	public GcAsteroidGenerationData RareAsteroidData
	{
		get => GetValue<GcAsteroidGenerationData>();
		set => TrySetValue<GcAsteroidGenerationData>(value);
	}

	public GcAsteroidSystemGenerationData(long address) : base(address)
	{

	}
}
