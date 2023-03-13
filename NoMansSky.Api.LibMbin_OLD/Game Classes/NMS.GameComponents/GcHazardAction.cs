using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHazardAction : NMSTemplate
{
	public GcPlayerHazardType Hazard
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RadiusBasedStrength
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcHazardAction(long address) : base(address)
	{

	}
}
