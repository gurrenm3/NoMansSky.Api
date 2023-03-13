using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyCameraData : NMSTemplate
{
	public Single CameraFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementBlendRateFree
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementBlendRateLocked
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MovementBlendRateLookLocked
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTransitionRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockedSpinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockedScaledPushSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockedScaledElevationSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreePanSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreePanSpeedTurbo
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeUpDownSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeUpDownSpeedTurbo
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeElevationBlendRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomOutSpin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomOutElevation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomOutPushDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomInRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinZoomDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxZoomDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPushingZoomDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPushingZoomDistanceScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraShakeDriftClip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraShakeDriftShift
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraShakeSmoothingRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraShakeMaximum
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGalaxyCameraData(long address) : base(address)
	{

	}
}
