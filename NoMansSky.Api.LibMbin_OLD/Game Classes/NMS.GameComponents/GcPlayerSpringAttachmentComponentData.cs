using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpringAttachmentComponentData : NMSTemplate
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

	public VirtualList<GcSpringLink> SpringLinks
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpringLink>(address + GetOffset()));
		set => TrySetValue<GcSpringLink>(value);
	}

	public GcPlayerSpringAttachmentComponentData(long address) : base(address)
	{

	}
}
