using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlackboardIntModifyData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Value
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcBlackboardIntModifyData.ModifyIntTypeEnum ModifyIntType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBlackboardIntModifyData.ModifyIntTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBlackboardIntModifyData.ModifyIntTypeEnum>(value);
	}

	public GcBlackboardIntModifyData(long address) : base(address)
	{

	}
}
