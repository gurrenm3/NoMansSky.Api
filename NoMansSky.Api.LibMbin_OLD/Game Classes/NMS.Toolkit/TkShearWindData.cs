using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkShearWindData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single OverallWindStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LdsWindStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LdsWindSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShearWindSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindShearVertpushStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindShearGradientStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindShearToDotLdsFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindStrengthToVertpush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkShearWindOctaveData Octave0
	{
		get => GetValue<TkShearWindOctaveData>();
		set => TrySetValue<TkShearWindOctaveData>(value);
	}

	public TkShearWindOctaveData Octave1
	{
		get => GetValue<TkShearWindOctaveData>();
		set => TrySetValue<TkShearWindOctaveData>(value);
	}

	public TkShearWindOctaveData Octave2
	{
		get => GetValue<TkShearWindOctaveData>();
		set => TrySetValue<TkShearWindOctaveData>(value);
	}

	public TkShearWindOctaveData Octave3
	{
		get => GetValue<TkShearWindOctaveData>();
		set => TrySetValue<TkShearWindOctaveData>(value);
	}

	public TkShearWindData(long address) : base(address)
	{

	}
}
