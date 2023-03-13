using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraAmbientBuildingData : NMSTemplate
{
	public NMSString0x10 Animation
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DroneAnimation
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseLookAt
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AvoidTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Boolean> AvailableBuildings
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 52));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Boolean> AvailableRaces
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 8));
		set => TrySetValue<Boolean>(value);
	}

	public GcCameraAmbientBuildingData(long address) : base(address)
	{

	}
}
