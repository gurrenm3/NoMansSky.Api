using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardCategory : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkBlackboardCategory.BlackboardCategoryEnum BlackboardCategory
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkBlackboardCategory.BlackboardCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkBlackboardCategory.BlackboardCategoryEnum>(value);
	}

	public TkBlackboardCategory(long address) : base(address)
	{

	}
}
