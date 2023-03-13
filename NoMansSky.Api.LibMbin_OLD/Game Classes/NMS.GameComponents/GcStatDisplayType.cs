using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatDisplayType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatDisplayType.StatDisplayTypeEnum StatDisplayType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatDisplayType.StatDisplayTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatDisplayType.StatDisplayTypeEnum>(value);
	}

	public GcStatDisplayType(long address) : base(address)
	{

	}
}
