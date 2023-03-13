using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMinimumUseConstraint : NMSTemplate
{
	public VirtualList<NMSString0x10> Modules
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinUses
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 Group
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMinimumUseConstraint(long address) : base(address)
	{

	}
}
