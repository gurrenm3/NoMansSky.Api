using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimJointLODData : NMSTemplate
{
	public Int32 LOD
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x40> JointNames
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public TkAnimJointLODData(long address) : base(address)
	{

	}
}
