using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechMeshType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMechMeshType.MechMeshTypeEnum MechMeshType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMechMeshType.MechMeshTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMechMeshType.MechMeshTypeEnum>(value);
	}

	public GcMechMeshType(long address) : base(address)
	{

	}
}
