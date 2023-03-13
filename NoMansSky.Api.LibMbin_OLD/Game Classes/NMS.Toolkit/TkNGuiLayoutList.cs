using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiLayoutList : NMSTemplate
{
	public VirtualList<TkNGuiLayoutListData> Layouts
	{
		get => cache.GetOrAddValue(new VirtualList<TkNGuiLayoutListData>(address + GetOffset()));
		set => TrySetValue<TkNGuiLayoutListData>(value);
	}

	public TkNGuiLayoutList(long address) : base(address)
	{

	}
}
