using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureDiscoveryThumbnailOverride : NMSTemplate
{
	public NMSString0x20A ContainsDescriptor
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single DiscoveryUIScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f DiscoveryUIOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcCreatureDiscoveryThumbnailOverride(long address) : base(address)
	{

	}
}
