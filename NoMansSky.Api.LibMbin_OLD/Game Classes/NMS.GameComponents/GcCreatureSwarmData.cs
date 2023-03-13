using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureSwarmData : NMSTemplate
{
	public Int32 MinCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SwarmMovementSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwarmMovementRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureSwarmData.SwarmMovementTypeEnum SwarmMovementType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureSwarmData.SwarmMovementTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureSwarmData.SwarmMovementTypeEnum>(value);
	}

	public VirtualList<GcCreatureSwarmDataParams> Params
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureSwarmDataParams>(address + GetOffset()));
		set => TrySetValue<GcCreatureSwarmDataParams>(value);
	}

	public GcCreatureSwarmData(long address) : base(address)
	{

	}
}
