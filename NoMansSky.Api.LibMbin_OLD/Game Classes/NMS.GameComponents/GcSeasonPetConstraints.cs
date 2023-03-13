using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonPetConstraints : NMSTemplate
{
	public NMSString0x10 CreatureId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MinRelativeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRelativeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpecificBiome
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBiomeType Biome
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public Single StartingTrust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public UInt64 TimeSinceLastEgg
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 TimeSinceBirth
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSeasonPetConstraints(long address) : base(address)
	{

	}
}
