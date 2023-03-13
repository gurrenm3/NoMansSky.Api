using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasDiscovery : NMSTemplate
{
	public GcAtlasDownloadType PackageType
	{
		get => GetValue<GcAtlasDownloadType>();
		set => TrySetValue<GcAtlasDownloadType>(value);
	}

	public GcDiscoveryOwner Owner
	{
		get => GetValue<GcDiscoveryOwner>();
		set => TrySetValue<GcDiscoveryOwner>(value);
	}

	public GcAtlasDiscoveryData Data
	{
		get => GetValue<GcAtlasDiscoveryData>();
		set => TrySetValue<GcAtlasDiscoveryData>(value);
	}

	public GcAtlasDiscoveryMetadata Metadata
	{
		get => GetValue<GcAtlasDiscoveryMetadata>();
		set => TrySetValue<GcAtlasDiscoveryMetadata>(value);
	}

	public GcAtlasMessage MessageData
	{
		get => GetValue<GcAtlasMessage>();
		set => TrySetValue<GcAtlasMessage>(value);
	}

	public NMSString0x40 RID
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x20 PTK
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcAtlasDiscovery(long address) : base(address)
	{

	}
}
