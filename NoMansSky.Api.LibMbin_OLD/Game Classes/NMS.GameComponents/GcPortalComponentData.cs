using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPortalComponentData : NMSTemplate
{
	public Single Temp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPortalComponentData(long address) : base(address)
	{

	}
}
