using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHotActionMenuTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcHotActionMenuTypes.HotActionMenuTypesEnum HotActionMenuTypes
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHotActionMenuTypes.HotActionMenuTypesEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHotActionMenuTypes.HotActionMenuTypesEnum>(value);
	}

	public GcHotActionMenuTypes(long address) : base(address)
	{

	}
}
