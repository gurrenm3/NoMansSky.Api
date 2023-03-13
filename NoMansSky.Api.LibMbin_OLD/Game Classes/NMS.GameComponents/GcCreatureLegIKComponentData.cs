using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureLegIKComponentData : NMSTemplate
{
	public Int32 Stuff
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCreatureLegIKComponentData(long address) : base(address)
	{

	}
}
