using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMetadataReadMask : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkMetadataReadMask.MetadataReadMaskEnum MetadataReadMask
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMetadataReadMask.MetadataReadMaskEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMetadataReadMask.MetadataReadMaskEnum>(value);
	}

	public TkMetadataReadMask(long address) : base(address)
	{

	}
}
