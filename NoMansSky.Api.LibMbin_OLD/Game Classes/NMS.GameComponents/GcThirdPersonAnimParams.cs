using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcThirdPersonAnimParams : NMSTemplate
{
	public Vector2f Velocity
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f VelocityXY
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single VelocityY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f MoveForce
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single MoveForceApplied
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f AimDirection
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Foot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitLR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitFB
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanLR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanFB
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFromGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Uphill
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeSinceJetpackEngaged
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcThirdPersonAnimParams(long address) : base(address)
	{

	}
}
