using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNetworkInterpolationComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNetworkInterpolationComponentData.SynchroniseScaleEnum SynchroniseScale
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNetworkInterpolationComponentData.SynchroniseScaleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNetworkInterpolationComponentData.SynchroniseScaleEnum>(value);
	}

	public Boolean SupportTeleportation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNetworkInterpolationComponentData(long address) : base(address)
	{

	}
}
