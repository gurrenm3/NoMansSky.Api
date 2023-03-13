using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShieldComponentData : NMSTemplate
{
	public Int32 Type
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcShieldComponentData(long address) : base(address)
	{

	}
}
