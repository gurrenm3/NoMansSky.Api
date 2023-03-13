using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraShakeMechanicalData : NMSTemplate
{
	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f ShakeStrength
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ShakeFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ExtraShakeFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f VibrateStrength
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f VibrateFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ExtraVibrateFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcCameraShakeMechanicalData(long address) : base(address)
	{

	}
}
