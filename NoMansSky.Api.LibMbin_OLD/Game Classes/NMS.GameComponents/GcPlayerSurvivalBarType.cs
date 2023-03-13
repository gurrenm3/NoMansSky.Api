using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSurvivalBarType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerSurvivalBarType.SurvivalBarEnum SurvivalBar
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerSurvivalBarType.SurvivalBarEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerSurvivalBarType.SurvivalBarEnum>(value);
	}

	public GcPlayerSurvivalBarType(long address) : base(address)
	{

	}
}
