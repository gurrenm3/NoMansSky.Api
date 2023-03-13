using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcResourceOrigin : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcResourceOrigin.ResourceOriginEnum ResourceOrigin
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcResourceOrigin.ResourceOriginEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcResourceOrigin.ResourceOriginEnum>(value);
	}

	public GcResourceOrigin(long address) : base(address)
	{

	}
}
