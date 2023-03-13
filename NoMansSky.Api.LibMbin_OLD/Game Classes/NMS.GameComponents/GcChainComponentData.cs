using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcChainComponentData : NMSTemplate
{
	public NMSString0x20 StartBone
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcChainComponentData(long address) : base(address)
	{

	}
}
