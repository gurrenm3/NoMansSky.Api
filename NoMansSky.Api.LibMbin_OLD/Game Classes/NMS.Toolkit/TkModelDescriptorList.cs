using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkModelDescriptorList : NMSTemplate
{
	public VirtualList<TkResourceDescriptorList> List
	{
		get => cache.GetOrAddValue(new VirtualList<TkResourceDescriptorList>(address + GetOffset()));
		set => TrySetValue<TkResourceDescriptorList>(value);
	}

	public TkModelDescriptorList(long address) : base(address)
	{

	}
}
