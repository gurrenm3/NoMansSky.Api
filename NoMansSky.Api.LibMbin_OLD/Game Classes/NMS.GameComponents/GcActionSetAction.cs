using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionSetAction : NMSTemplate
{
	public GcActionUseType Status
	{
		get => GetValue<GcActionUseType>();
		set => TrySetValue<GcActionUseType>(value);
	}

	public GcInputActions Action
	{
		get => GetValue<GcInputActions>();
		set => TrySetValue<GcInputActions>(value);
	}

	public GcActionSetAction(long address) : base(address)
	{

	}
}
