using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkPostProcessData : NMSTemplate
{
	public Single DOFNearPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SaturationDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrightnessDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ContrastDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SaturationFinal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrightnessFinal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ContrastFinal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkPostProcessData(long address) : base(address)
	{

	}
}
