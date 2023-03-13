using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartStyle : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseBuildingPartStyle.StyleEnum Style
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPartStyle.StyleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingPartStyle.StyleEnum>(value);
	}

	public GcBaseBuildingPartStyle(long address) : base(address)
	{

	}
}
