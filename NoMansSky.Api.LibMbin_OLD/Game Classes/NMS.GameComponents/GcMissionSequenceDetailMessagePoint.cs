using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceDetailMessagePoint : NMSTemplate
{
	public NMSString0x20A Text
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceDetailMessagePoint.PointStateEnum PointState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceDetailMessagePoint.PointStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceDetailMessagePoint.PointStateEnum>(value);
	}

	public NMSString0x10 InsertItemName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionSequenceDetailMessagePoint(long address) : base(address)
	{

	}
}
