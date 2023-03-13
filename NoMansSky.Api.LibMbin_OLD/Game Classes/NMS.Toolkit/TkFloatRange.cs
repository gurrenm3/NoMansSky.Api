using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkFloatRange : NMSTemplate
{
	public Single Minimum
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Maximum
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkFloatRange(long address) : base(address)
	{

	}
}
