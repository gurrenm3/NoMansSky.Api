using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFontTable : NMSTemplate
{
	public VirtualArray<GcFontData> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFontData>(address + GetOffset(), 8));
		set => TrySetValue<GcFontData>(value);
	}

	public GcFontTable(long address) : base(address)
	{

	}
}
