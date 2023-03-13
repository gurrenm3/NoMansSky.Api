using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInteractiveSceneData : NMSTemplate
{
	public NMSString0x20 Id
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<TkInteractiveControlData> Controls
	{
		get => cache.GetOrAddValue(new VirtualList<TkInteractiveControlData>(address + GetOffset()));
		set => TrySetValue<TkInteractiveControlData>(value);
	}

	public TkInteractiveSceneData(long address) : base(address)
	{

	}
}
