using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralInstance : NMSTemplate
{
	public VirtualArray<TkProceduralInstanceData> Data
	{
		get => cache.GetOrAddValue(new VirtualArray<TkProceduralInstanceData>(address + GetOffset(), 16));
		set => TrySetValue<TkProceduralInstanceData>(value);
	}

	public TkProceduralInstance(long address) : base(address)
	{

	}
}
