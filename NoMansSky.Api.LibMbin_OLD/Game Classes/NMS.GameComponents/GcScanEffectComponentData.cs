using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEffectComponentData : NMSTemplate
{
	public VirtualList<GcScanEffectData> ScanEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEffectData>(address + GetOffset()));
		set => TrySetValue<GcScanEffectData>(value);
	}

	public NMSString0x40 NodeName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcScanEffectComponentData(long address) : base(address)
	{

	}
}
