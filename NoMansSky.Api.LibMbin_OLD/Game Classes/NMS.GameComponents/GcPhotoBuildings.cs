using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoBuildings : NMSTemplate
{
	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPhotoBuilding BuildingType
	{
		get => GetValue<GcPhotoBuilding>();
		set => TrySetValue<GcPhotoBuilding>(value);
	}

	public GcPhotoBuildings(long address) : base(address)
	{

	}
}
