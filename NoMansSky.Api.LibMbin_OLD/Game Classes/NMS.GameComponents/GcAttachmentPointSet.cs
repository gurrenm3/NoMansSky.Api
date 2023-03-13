using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAttachmentPointSet : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x40 DebugName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 BoneName
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public VirtualList<GcAttachmentPointData> FixedPoints
	{
		get => cache.GetOrAddValue(new VirtualList<GcAttachmentPointData>(address + GetOffset()));
		set => TrySetValue<GcAttachmentPointData>(value);
	}

	public GcAttachmentPointSet(long address) : base(address)
	{

	}
}
