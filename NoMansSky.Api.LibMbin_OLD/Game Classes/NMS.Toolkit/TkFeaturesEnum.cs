using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkFeaturesEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkFeaturesEnum.FeatureTypesEnum FeatureTypes
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkFeaturesEnum.FeatureTypesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkFeaturesEnum.FeatureTypesEnum>(value);
	}

	public TkFeaturesEnum(long address) : base(address)
	{

	}
}
