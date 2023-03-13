using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageRequestWarp : NMSTemplate
{
	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMessageRequestWarp(long address) : base(address)
	{

	}
}
