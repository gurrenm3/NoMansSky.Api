using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectorOffsetData : NMSTemplate
{
	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInWorldUIScreenData Active
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData Inactive
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcProjectorOffsetData(long address) : base(address)
	{

	}
}
