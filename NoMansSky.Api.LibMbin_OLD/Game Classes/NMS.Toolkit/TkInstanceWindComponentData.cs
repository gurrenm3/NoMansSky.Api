using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInstanceWindComponentData : NMSTemplate
{
	public Boolean EnableLdsWind
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BaseMass
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MassReduction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpringReduction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LinearDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpringNonDirFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpringLengthFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkInstanceWindComponentData(long address) : base(address)
	{

	}
}
