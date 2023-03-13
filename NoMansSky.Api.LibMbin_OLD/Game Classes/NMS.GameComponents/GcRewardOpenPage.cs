using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardOpenPage : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardOpenPage.PageToOpenEnum PageToOpen
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardOpenPage.PageToOpenEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardOpenPage.PageToOpenEnum>(value);
	}

	public Boolean ReinteractWhenComplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardOpenPage(long address) : base(address)
	{

	}
}
