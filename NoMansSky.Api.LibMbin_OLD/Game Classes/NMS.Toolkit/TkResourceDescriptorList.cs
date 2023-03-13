using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkResourceDescriptorList : NMSTemplate
{
	public NMSString0x10 TypeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<TkResourceDescriptorData> Descriptors
	{
		get => cache.GetOrAddValue(new VirtualList<TkResourceDescriptorData>(address + GetOffset()));
		set => TrySetValue<TkResourceDescriptorData>(value);
	}

	public TkResourceDescriptorList(long address) : base(address)
	{

	}
}
