using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNetReplicatedEntityComponentData : NMSTemplate
{
	public VirtualList<NMSString0x80> ReplicaComponentMask
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.ReplicationRangeEnum ReplicationRange
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.ReplicationRangeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.ReplicationRangeEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.SpawnTypeEnum SpawnType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.SpawnTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNetReplicatedEntityComponentData.SpawnTypeEnum>(value);
	}

	public Boolean IgnoreComponents
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNetReplicatedEntityComponentData(long address) : base(address)
	{

	}
}
