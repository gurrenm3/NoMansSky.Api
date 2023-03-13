using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelRobotComponentData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSentinelTypes Type
	{
		get => GetValue<GcSentinelTypes>();
		set => TrySetValue<GcSentinelTypes>(value);
	}

	public GcSentinelRobotComponentData(long address) : base(address)
	{

	}
}
