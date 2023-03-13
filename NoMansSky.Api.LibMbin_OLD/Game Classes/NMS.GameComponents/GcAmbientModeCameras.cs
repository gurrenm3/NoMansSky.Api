using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAmbientModeCameras : NMSTemplate
{
	public VirtualList<GcCameraAmbientBuildingData> BuildingCameraAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraAmbientBuildingData>(address + GetOffset()));
		set => TrySetValue<GcCameraAmbientBuildingData>(value);
	}

	public VirtualList<GcCameraAmbientSpaceData> SpaceCameraAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraAmbientSpaceData>(address + GetOffset()));
		set => TrySetValue<GcCameraAmbientSpaceData>(value);
	}

	public VirtualList<GcCameraAmbientSpecialData> SpecialCameraAnimations
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraAmbientSpecialData>(address + GetOffset()));
		set => TrySetValue<GcCameraAmbientSpecialData>(value);
	}

	public GcAmbientModeCameras(long address) : base(address)
	{

	}
}
