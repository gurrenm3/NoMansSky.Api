using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStyleProp_Font : NMSTemplate
{
	public Int32 FontIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcStyleProp_Font(long address) : base(address)
	{

	}
}
