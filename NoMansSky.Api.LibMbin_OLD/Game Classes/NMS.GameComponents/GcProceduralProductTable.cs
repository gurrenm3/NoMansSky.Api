using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralProductTable : NMSTemplate
{
	public VirtualArray<GcProceduralProductData> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<GcProceduralProductData>(address + GetOffset(), 26));
		set => TrySetValue<GcProceduralProductData>(value);
	}

	public GcProceduralProductTable(long address) : base(address)
	{

	}
}
