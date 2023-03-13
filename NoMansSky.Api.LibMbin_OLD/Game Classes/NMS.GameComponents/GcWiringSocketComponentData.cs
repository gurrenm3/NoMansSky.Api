using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWiringSocketComponentData : NMSTemplate
{
	public Boolean Value
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcWiringSocketComponentData(long address) : base(address)
	{

	}
}
