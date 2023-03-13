using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoFlora : NMSTemplate
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

	public GcPhotoPlant PlantType
	{
		get => GetValue<GcPhotoPlant>();
		set => TrySetValue<GcPhotoPlant>(value);
	}

	public GcPhotoFlora(long address) : base(address)
	{

	}
}
