using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEncyclopediaComponentData : NMSTemplate
{
	public GcDiscoveryType Type
	{
		get => GetValue<GcDiscoveryType>();
		set => TrySetValue<GcDiscoveryType>(value);
	}

	public GcEncyclopediaComponentData(long address) : base(address)
	{

	}
}
