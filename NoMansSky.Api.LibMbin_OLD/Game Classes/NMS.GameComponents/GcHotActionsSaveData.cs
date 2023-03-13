using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHotActionsSaveData : NMSTemplate
{
	public VirtualArray<GcQuickMenuActionSaveData> KeyActions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcQuickMenuActionSaveData>(address + GetOffset(), 10));
		set => TrySetValue<GcQuickMenuActionSaveData>(value);
	}

	public GcHotActionsSaveData(long address) : base(address)
	{

	}
}
