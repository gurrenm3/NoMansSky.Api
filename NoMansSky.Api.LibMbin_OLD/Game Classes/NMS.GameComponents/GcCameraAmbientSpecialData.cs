using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraAmbientSpecialData : NMSTemplate
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

	public libMBIN.NMS.GameComponents.GcCameraAmbientSpecialData.CameraOriginEnum CameraOrigin
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCameraAmbientSpecialData.CameraOriginEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCameraAmbientSpecialData.CameraOriginEnum>(value);
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

	public GcCameraAmbientSpecialData(long address) : base(address)
	{

	}
}
