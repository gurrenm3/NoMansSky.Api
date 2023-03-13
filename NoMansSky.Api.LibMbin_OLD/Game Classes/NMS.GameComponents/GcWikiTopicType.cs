using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWikiTopicType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWikiTopicType.WikiTopicTypeEnum WikiTopicType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWikiTopicType.WikiTopicTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWikiTopicType.WikiTopicTypeEnum>(value);
	}

	public GcWikiTopicType(long address) : base(address)
	{

	}
}
