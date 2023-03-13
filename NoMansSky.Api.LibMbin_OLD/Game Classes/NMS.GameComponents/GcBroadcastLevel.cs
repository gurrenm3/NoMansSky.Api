using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBroadcastLevel : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBroadcastLevel.BroadcastLevelEnum BroadcastLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBroadcastLevel.BroadcastLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBroadcastLevel.BroadcastLevelEnum>(value);
	}

	public GcBroadcastLevel(long address) : base(address)
	{

	}
}
