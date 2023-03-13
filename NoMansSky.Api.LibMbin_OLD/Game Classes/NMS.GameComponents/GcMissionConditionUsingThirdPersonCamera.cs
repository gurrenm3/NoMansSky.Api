using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionUsingThirdPersonCamera.UsingCameraModeEnum UsingCameraMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionUsingThirdPersonCamera.UsingCameraModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionUsingThirdPersonCamera.UsingCameraModeEnum>(value);
	}

	public GcMissionConditionUsingThirdPersonCamera(long address) : base(address)
	{

	}
}
