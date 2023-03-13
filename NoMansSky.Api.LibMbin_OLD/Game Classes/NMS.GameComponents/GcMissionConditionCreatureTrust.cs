using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCreatureTrust : NMSTemplate
{
	public Single Trust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionCreatureTrust(long address) : base(address)
	{

	}
}
