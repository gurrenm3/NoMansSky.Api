using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterBaseComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFreighterBaseComponentData.FreighterBaseGenerationModeEnum FreighterBaseGenerationMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFreighterBaseComponentData.FreighterBaseGenerationModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFreighterBaseComponentData.FreighterBaseGenerationModeEnum>(value);
	}

	public VirtualArray<GcFreighterBaseOptions> FreighterBaseOptions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFreighterBaseOptions>(address + GetOffset(), 4));
		set => TrySetValue<GcFreighterBaseOptions>(value);
	}

	public NMSString0x80 FreighterBaseForPlayerReset
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 WFCBuildingFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcFreighterBaseComponentData(long address) : base(address)
	{

	}
}
