using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceMapObjectData : NMSTemplate
{
	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean TintModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleMagnitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Orient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSpaceMapObjectData(long address) : base(address)
	{

	}
}
