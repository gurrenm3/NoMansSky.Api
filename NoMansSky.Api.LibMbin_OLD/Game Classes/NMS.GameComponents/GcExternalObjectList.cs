using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExternalObjectList : NMSTemplate
{
	public GcEnvironmentSpawnData Objects
	{
		get => GetValue<GcEnvironmentSpawnData>();
		set => TrySetValue<GcEnvironmentSpawnData>(value);
	}

	public GcExternalObjectList(long address) : base(address)
	{

	}
}
