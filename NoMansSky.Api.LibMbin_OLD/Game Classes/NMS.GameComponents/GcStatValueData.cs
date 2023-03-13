using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatValueData : NMSTemplate
{
	public Int32 IntValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FloatValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Denominator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcStatValueData(long address) : base(address)
	{

	}
}
