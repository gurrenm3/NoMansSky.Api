using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCPropTable : NMSTemplate
{
	public VirtualArray<GcNPCPropInfo> Props
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCPropInfo>(address + GetOffset(), 13));
		set => TrySetValue<GcNPCPropInfo>(value);
	}

	public GcNPCPropTable(long address) : base(address)
	{

	}
}
