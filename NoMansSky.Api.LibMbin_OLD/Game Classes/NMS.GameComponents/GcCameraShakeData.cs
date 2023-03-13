using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraShakeData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single TimeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DecayRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrengthScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraShakeCapturedData CapturedData
	{
		get => GetValue<GcCameraShakeCapturedData>();
		set => TrySetValue<GcCameraShakeCapturedData>(value);
	}

	public GcCameraShakeMechanicalData MechanicalData
	{
		get => GetValue<GcCameraShakeMechanicalData>();
		set => TrySetValue<GcCameraShakeMechanicalData>(value);
	}

	public Single FovStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FovFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraShakeData(long address) : base(address)
	{

	}
}
