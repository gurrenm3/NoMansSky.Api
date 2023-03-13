using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardComparisonTypeEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkBlackboardComparisonTypeEnum.ComparisonTypeEnum ComparisonType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkBlackboardComparisonTypeEnum.ComparisonTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkBlackboardComparisonTypeEnum.ComparisonTypeEnum>(value);
	}

	public TkBlackboardComparisonTypeEnum(long address) : base(address)
	{

	}
}
