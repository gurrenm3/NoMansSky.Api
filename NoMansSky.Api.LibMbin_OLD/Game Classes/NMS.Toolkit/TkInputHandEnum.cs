using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputHandEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkInputHandEnum.InputHandEnum InputHand
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkInputHandEnum.InputHandEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkInputHandEnum.InputHandEnum>(value);
	}

	public TkInputHandEnum(long address) : base(address)
	{

	}
}
