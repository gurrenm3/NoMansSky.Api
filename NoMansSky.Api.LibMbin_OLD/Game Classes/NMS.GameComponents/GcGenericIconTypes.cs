using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGenericIconTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGenericIconTypes.GenericIconTypeEnum GenericIconType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGenericIconTypes.GenericIconTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGenericIconTypes.GenericIconTypeEnum>(value);
	}

	public GcGenericIconTypes(long address) : base(address)
	{

	}
}
