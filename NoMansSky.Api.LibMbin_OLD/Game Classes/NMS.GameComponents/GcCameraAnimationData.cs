using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraAnimationData : NMSTemplate
{
	public TkModelResource CameraAnimation
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcCameraAnimationData(long address) : base(address)
	{

	}
}
