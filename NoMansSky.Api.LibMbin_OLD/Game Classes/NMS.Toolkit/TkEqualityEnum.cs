using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEqualityEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkEqualityEnum.EqualityEnumEnum EqualityEnum
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkEqualityEnum.EqualityEnumEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkEqualityEnum.EqualityEnumEnum>(value);
	}

	public TkEqualityEnum(long address) : base(address)
	{

	}
}
