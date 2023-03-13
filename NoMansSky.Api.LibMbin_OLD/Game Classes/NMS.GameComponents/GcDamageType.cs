using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDamageType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDamageType.DamageTypeEnum DamageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDamageType.DamageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDamageType.DamageTypeEnum>(value);
	}

	public GcDamageType(long address) : base(address)
	{

	}
}
