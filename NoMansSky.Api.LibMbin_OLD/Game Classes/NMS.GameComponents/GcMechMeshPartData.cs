using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechMeshPartData : NMSTemplate
{
	public VirtualArray<GcMechMeshPartTypeData> MeshTypes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcMechMeshPartTypeData>(address + GetOffset(), 2));
		set => TrySetValue<GcMechMeshPartTypeData>(value);
	}

	public GcMechMeshPartData(long address) : base(address)
	{

	}
}
