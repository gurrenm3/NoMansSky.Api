using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiSpacingData : NMSTemplate
{
	public GcNGuiElementData ElementData
	{
		get => GetValue<GcNGuiElementData>();
		set => TrySetValue<GcNGuiElementData>(value);
	}

	public GcNGuiSpacingData(long address) : base(address)
	{

	}
}
