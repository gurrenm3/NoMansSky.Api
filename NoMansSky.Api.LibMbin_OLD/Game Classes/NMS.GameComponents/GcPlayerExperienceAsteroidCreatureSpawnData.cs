using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerExperienceAsteroidCreatureSpawnData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f SmallMinMax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f MediumMinMax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f LargeMinMax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcPlayerExperienceAsteroidCreatureSpawnData(long address) : base(address)
	{

	}
}
