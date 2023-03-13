using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureSpawnEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureSpawnEnum.IncrementorEnum Incrementor
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureSpawnEnum.IncrementorEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureSpawnEnum.IncrementorEnum>(value);
	}

	public GcCreatureSpawnEnum(long address) : base(address)
	{

	}
}
