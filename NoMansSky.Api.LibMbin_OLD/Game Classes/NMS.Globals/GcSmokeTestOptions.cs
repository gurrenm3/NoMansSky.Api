using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSmokeTestOptions : NMSTemplate
{
	public Single InitialPause
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmokeTestFlashTimeDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraFastHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraFastMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraPitchAngleDeg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraPitchSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GifMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 GifFrames
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single GifTimeBetweenKeyframes
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetFlightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetFlightTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmokeBotTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SmokeBotNumWalksBeforeWarp
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSmokeTestOptions(long address) : base(address)
	{

	}
}
