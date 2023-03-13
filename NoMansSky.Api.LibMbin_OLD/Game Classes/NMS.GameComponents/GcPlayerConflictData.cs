using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerConflictData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerConflictData.ConflictLevelEnum ConflictLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerConflictData.ConflictLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerConflictData.ConflictLevelEnum>(value);
	}

	public GcPlayerConflictData(long address) : base(address)
	{

	}
}
