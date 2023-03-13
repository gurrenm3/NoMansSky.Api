using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkInputEnum.InputButtonEnum InputButton
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkInputEnum.InputButtonEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkInputEnum.InputButtonEnum>(value);
	}

	public TkInputEnum(long address) : base(address)
	{

	}
}
