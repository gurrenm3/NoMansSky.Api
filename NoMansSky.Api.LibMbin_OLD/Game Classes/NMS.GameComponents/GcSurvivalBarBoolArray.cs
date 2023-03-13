using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSurvivalBarBoolArray : NMSTemplate
{
	public VirtualArray<Boolean> Values
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 3));
		set => TrySetValue<Boolean>(value);
	}

	public GcSurvivalBarBoolArray(long address) : base(address)
	{

	}
}
