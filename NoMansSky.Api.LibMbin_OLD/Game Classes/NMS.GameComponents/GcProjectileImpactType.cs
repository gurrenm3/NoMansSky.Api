using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectileImpactType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcProjectileImpactType.ImpactEnum Impact
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProjectileImpactType.ImpactEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProjectileImpactType.ImpactEnum>(value);
	}

	public GcProjectileImpactType(long address) : base(address)
	{

	}
}
