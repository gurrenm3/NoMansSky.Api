using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlackboardFloatCompareDecoratorData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueFloat CompareTo
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public TkBlackboardComparisonTypeEnum CompareBlackboardValueType
	{
		get => GetValue<TkBlackboardComparisonTypeEnum>();
		set => TrySetValue<TkBlackboardComparisonTypeEnum>(value);
	}

	public NMSTemplate OnTrue
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSTemplate OnFalse
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcBlackboardFloatCompareDecoratorData(long address) : base(address)
	{

	}
}
