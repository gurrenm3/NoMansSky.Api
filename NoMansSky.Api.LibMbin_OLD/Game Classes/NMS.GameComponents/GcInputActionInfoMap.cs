using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputActionInfoMap : NMSTemplate
{
	public VirtualArray<GcInputActionInfo> ActionMap
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInputActionInfo>(address + GetOffset(), 289));
		set => TrySetValue<GcInputActionInfo>(value);
	}

	public GcInputActionInfoMap(long address) : base(address)
	{

	}
}
