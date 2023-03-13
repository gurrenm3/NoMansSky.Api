using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartStyleModel : NMSTemplate
{
	public GcBaseBuildingPartStyle Style
	{
		get => GetValue<GcBaseBuildingPartStyle>();
		set => TrySetValue<GcBaseBuildingPartStyle>(value);
	}

	public TkModelResource Model
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource Inactive
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcBaseBuildingPartStyleModel(long address) : base(address)
	{

	}
}
