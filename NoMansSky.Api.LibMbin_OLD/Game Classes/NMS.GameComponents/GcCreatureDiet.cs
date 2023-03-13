using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureDiet : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureDiet.DietEnum Diet
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureDiet.DietEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureDiet.DietEnum>(value);
	}

	public GcCreatureDiet(long address) : base(address)
	{

	}
}
