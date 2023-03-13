using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseOffsetEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNoiseOffsetEnum.OffsetTypeEnum OffsetType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseOffsetEnum.OffsetTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseOffsetEnum.OffsetTypeEnum>(value);
	}

	public TkNoiseOffsetEnum(long address) : base(address)
	{

	}
}
