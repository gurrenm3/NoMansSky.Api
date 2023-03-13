using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDecorationComponentData : NMSTemplate
{
	public Single StartOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTestRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDecorationComponentData(long address) : base(address)
	{

	}
}
