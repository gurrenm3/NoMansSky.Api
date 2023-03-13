using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkShearWindOctaveData : NMSTemplate
{
	public Single MinStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrengthVariationFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkShearWindOctaveData(long address) : base(address)
	{

	}
}
