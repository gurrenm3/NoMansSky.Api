using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputActions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInputActions.InputActionEnum InputAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInputActions.InputActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInputActions.InputActionEnum>(value);
	}

	public GcInputActions(long address) : base(address)
	{

	}
}
