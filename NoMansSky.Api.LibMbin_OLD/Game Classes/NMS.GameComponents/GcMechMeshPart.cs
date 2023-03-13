using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechMeshPart : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMechMeshPart.MechMeshPartEnum MechMeshPart
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMechMeshPart.MechMeshPartEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMechMeshPart.MechMeshPartEnum>(value);
	}

	public GcMechMeshPart(long address) : base(address)
	{

	}
}
