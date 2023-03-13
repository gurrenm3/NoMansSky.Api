using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStyleProp_Size : NMSTemplate
{
	public Single FontSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcStyleProp_Size(long address) : base(address)
	{

	}
}
