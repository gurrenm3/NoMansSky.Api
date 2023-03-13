using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcActionSetType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcActionSetType.ActionSetTypeEnum ActionSetType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcActionSetType.ActionSetTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcActionSetType.ActionSetTypeEnum>(value);
	}

	public GcActionSetType(long address) : base(address)
	{

	}
}
