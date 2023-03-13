using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPunctuationDelayTable : NMSTemplate
{
	public VirtualArray<GcPunctuationDelayData> PunctuationDelays
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPunctuationDelayData>(address + GetOffset(), 5));
		set => TrySetValue<GcPunctuationDelayData>(value);
	}

	public GcPunctuationDelayTable(long address) : base(address)
	{

	}
}
