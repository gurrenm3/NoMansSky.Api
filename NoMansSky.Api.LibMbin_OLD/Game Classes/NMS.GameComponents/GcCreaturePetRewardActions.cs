using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetRewardActions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreaturePetRewardActions.PetActionEnum PetAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreaturePetRewardActions.PetActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreaturePetRewardActions.PetActionEnum>(value);
	}

	public GcCreaturePetRewardActions(long address) : base(address)
	{

	}
}
