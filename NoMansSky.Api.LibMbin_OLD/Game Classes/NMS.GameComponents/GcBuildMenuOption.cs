using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildMenuOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildMenuOption.BuildMenuOptionEnum BuildMenuOption
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildMenuOption.BuildMenuOptionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildMenuOption.BuildMenuOptionEnum>(value);
	}

	public GcBuildMenuOption(long address) : base(address)
	{

	}
}
