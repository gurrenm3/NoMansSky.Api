using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiEditorLayout : NMSTemplate
{
	public VirtualArray<TkNGuiWindowLayoutData> Windows
	{
		get => cache.GetOrAddValue(new VirtualArray<TkNGuiWindowLayoutData>(address + GetOffset(), 256));
		set => TrySetValue<TkNGuiWindowLayoutData>(value);
	}

	public TkNGuiEditorLayout(long address) : base(address)
	{

	}
}
