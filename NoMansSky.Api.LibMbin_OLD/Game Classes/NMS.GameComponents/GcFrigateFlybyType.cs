using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateFlybyType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFrigateFlybyType.FrigateFlybyTypeEnum FrigateFlybyType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFrigateFlybyType.FrigateFlybyTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFrigateFlybyType.FrigateFlybyTypeEnum>(value);
	}

	public GcFrigateFlybyType(long address) : base(address)
	{

	}
}
