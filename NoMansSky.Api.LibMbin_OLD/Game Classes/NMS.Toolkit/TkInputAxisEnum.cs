using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputAxisEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkInputAxisEnum.InputAxisEnum InputAxis
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkInputAxisEnum.InputAxisEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkInputAxisEnum.InputAxisEnum>(value);
	}

	public TkInputAxisEnum(long address) : base(address)
	{

	}
}
