using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraAmbientSpaceData : NMSTemplate
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

	public libMBIN.NMS.GameComponents.GcCameraAmbientSpaceData.OriginEnum Origin
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCameraAmbientSpaceData.OriginEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCameraAmbientSpaceData.OriginEnum>(value);
	}

	public GcCameraAmbientSpaceData(long address) : base(address)
	{

	}
}
