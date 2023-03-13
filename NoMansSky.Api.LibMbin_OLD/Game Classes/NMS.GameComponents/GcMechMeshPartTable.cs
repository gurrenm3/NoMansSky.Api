using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechMeshPartTable : NMSTemplate
{
	public VirtualArray<GcMechMeshPartData> Parts
	{
		get => cache.GetOrAddValue(new VirtualArray<GcMechMeshPartData>(address + GetOffset(), 5));
		set => TrySetValue<GcMechMeshPartData>(value);
	}

	public GcMechMeshPartTable(long address) : base(address)
	{

	}
}
