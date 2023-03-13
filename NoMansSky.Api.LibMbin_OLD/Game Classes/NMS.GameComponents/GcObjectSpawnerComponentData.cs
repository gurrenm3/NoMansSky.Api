using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectSpawnerComponentData : NMSTemplate
{
	public TkModelResource Object
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Int32 SpawnPowerCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpawnCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcObjectSpawnerComponentData(long address) : base(address)
	{

	}
}
