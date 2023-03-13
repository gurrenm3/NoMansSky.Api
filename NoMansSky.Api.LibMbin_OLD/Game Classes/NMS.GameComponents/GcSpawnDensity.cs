using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpawnDensity : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcSpawnDensity.CoverageTypeEnum CoverageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpawnDensity.CoverageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpawnDensity.CoverageTypeEnum>(value);
	}

	public Single PatchSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpawnDensity(long address) : base(address)
	{

	}
}
