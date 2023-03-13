using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCustomisationComponentData.CustomisationDataTypeEnum CustomisationDataType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCustomisationComponentData.CustomisationDataTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCustomisationComponentData.CustomisationDataTypeEnum>(value);
	}

	public GcCustomisationComponentData(long address) : base(address)
	{

	}
}
