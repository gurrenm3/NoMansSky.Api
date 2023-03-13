using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHeightAdjustComponentData : NMSTemplate
{
	public Single HeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHeightAdjustComponentData(long address) : base(address)
	{

	}
}
