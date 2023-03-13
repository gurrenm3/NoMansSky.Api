using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWordCategoryTableEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWordCategoryTableEnum.wordcategorytableEnumEnum wordcategorytableEnum
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWordCategoryTableEnum.wordcategorytableEnumEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWordCategoryTableEnum.wordcategorytableEnumEnum>(value);
	}

	public GcWordCategoryTableEnum(long address) : base(address)
	{

	}
}
