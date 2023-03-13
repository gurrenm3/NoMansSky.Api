using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatTrackType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatTrackType.StatTrackTypeEnum StatTrackType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatTrackType.StatTrackTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatTrackType.StatTrackTypeEnum>(value);
	}

	public GcStatTrackType(long address) : base(address)
	{

	}
}
