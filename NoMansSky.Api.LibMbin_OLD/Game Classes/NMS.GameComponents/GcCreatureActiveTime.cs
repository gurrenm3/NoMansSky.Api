using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureActiveTime : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureActiveTime.CreatureActiveTimeEnum CreatureActiveTime
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureActiveTime.CreatureActiveTimeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureActiveTime.CreatureActiveTimeEnum>(value);
	}

	public GcCreatureActiveTime(long address) : base(address)
	{

	}
}
