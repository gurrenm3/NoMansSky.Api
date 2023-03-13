using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHemiSphere : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureHemiSphere.CreatureHemiSphereEnum CreatureHemiSphere
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureHemiSphere.CreatureHemiSphereEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureHemiSphere.CreatureHemiSphereEnum>(value);
	}

	public GcCreatureHemiSphere(long address) : base(address)
	{

	}
}
