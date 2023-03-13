using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureAttractorComponentData : NMSTemplate
{
	public Boolean Universal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Static
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ArriveDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureAttractorComponentData.AttractorTypeEnum AttractorType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureAttractorComponentData.AttractorTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureAttractorComponentData.AttractorTypeEnum>(value);
	}

	public GcCreatureAttractorComponentData(long address) : base(address)
	{

	}
}
