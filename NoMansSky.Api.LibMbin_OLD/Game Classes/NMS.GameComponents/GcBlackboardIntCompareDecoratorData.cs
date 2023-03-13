using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBlackboardIntCompareDecoratorData : NMSTemplate
{
	public NMSString0x10 Key
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkBlackboardDefaultValueInteger CompareTo
	{
		get => GetValue<TkBlackboardDefaultValueInteger>();
		set => TrySetValue<TkBlackboardDefaultValueInteger>(value);
	}

	public TkBlackboardComparisonTypeEnum Comparison
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

	public GcBlackboardIntCompareDecoratorData(long address) : base(address)
	{

	}
}
