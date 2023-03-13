using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceModifyStat : NMSTemplate
{
	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcStatModifyType ModifyType
	{
		get => GetValue<GcStatModifyType>();
		set => TrySetValue<GcStatModifyType>(value);
	}

	public GcMissionSequenceModifyStat(long address) : base(address)
	{

	}
}
