using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBaseClaimed : NMSTemplate
{
	public Boolean Claimed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPersistentBaseTypes Base
	{
		get => GetValue<GcPersistentBaseTypes>();
		set => TrySetValue<GcPersistentBaseTypes>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionConditionBaseClaimed.IsOnCurrentSystemEnum IsOnCurrentSystem
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionBaseClaimed.IsOnCurrentSystemEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionBaseClaimed.IsOnCurrentSystemEnum>(value);
	}

	public Boolean MustBeInBase
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MinParts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionBaseClaimed(long address) : base(address)
	{

	}
}
