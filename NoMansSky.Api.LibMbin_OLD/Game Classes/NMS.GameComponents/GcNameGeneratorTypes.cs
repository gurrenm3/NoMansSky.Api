using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNameGeneratorTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNameGeneratorTypes.MarkovSelectorEnum MarkovSelector
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNameGeneratorTypes.MarkovSelectorEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNameGeneratorTypes.MarkovSelectorEnum>(value);
	}

	public GcNameGeneratorTypes(long address) : base(address)
	{

	}
}
