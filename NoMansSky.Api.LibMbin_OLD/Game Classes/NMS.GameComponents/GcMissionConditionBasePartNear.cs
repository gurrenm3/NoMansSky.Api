using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBasePartNear : NMSTemplate
{
	public NMSString0x10 PartID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionBasePartNear(long address) : base(address)
	{

	}
}
