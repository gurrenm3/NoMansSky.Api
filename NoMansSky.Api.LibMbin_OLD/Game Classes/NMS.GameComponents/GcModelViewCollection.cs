using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModelViewCollection : NMSTemplate
{
	public VirtualArray<TkModelRendererData> ModelViews
	{
		get => cache.GetOrAddValue(new VirtualArray<TkModelRendererData>(address + GetOffset(), 33));
		set => TrySetValue<TkModelRendererData>(value);
	}

	public GcModelViewCollection(long address) : base(address)
	{

	}
}
