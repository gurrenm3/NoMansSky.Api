using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasDownloadType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAtlasDownloadType.DownloadTypeEnum DownloadType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAtlasDownloadType.DownloadTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAtlasDownloadType.DownloadTypeEnum>(value);
	}

	public GcAtlasDownloadType(long address) : base(address)
	{

	}
}
