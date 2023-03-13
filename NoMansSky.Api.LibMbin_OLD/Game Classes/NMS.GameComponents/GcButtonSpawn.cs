using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcButtonSpawn : NMSTemplate
{
	public TkInputEnum Button
	{
		get => GetValue<TkInputEnum>();
		set => TrySetValue<TkInputEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcButtonSpawn.EventEnum Event
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcButtonSpawn.EventEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcButtonSpawn.EventEnum>(value);
	}

	public GcButtonSpawnOffset Offset
	{
		get => GetValue<GcButtonSpawnOffset>();
		set => TrySetValue<GcButtonSpawnOffset>(value);
	}

	public GcButtonSpawn(long address) : base(address)
	{

	}
}
