using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInputValidation : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkInputValidation.InputValidationEnum InputValidation
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkInputValidation.InputValidationEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkInputValidation.InputValidationEnum>(value);
	}

	public TkInputValidation(long address) : base(address)
	{

	}
}
