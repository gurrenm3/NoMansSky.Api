using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWarpAction : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWarpAction.WarpTypeEnum WarpType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWarpAction.WarpTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWarpAction.WarpTypeEnum>(value);
	}

	public GcWarpAction(long address) : base(address)
	{

	}
}
