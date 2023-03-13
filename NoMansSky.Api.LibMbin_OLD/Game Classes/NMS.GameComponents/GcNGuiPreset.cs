using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiPreset : NMSTemplate
{
	public NMSString0x80 Font
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<GcNGuiPresetGraphic> Layer
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNGuiPresetGraphic>(address + GetOffset(), 10));
		set => TrySetValue<GcNGuiPresetGraphic>(value);
	}

	public VirtualArray<GcNGuiPresetGraphic> Graphic
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNGuiPresetGraphic>(address + GetOffset(), 10));
		set => TrySetValue<GcNGuiPresetGraphic>(value);
	}

	public VirtualArray<GcNGuiPresetText> Text
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNGuiPresetText>(address + GetOffset(), 10));
		set => TrySetValue<GcNGuiPresetText>(value);
	}

	public GcNGuiLayoutData SpacingLayout
	{
		get => GetValue<GcNGuiLayoutData>();
		set => TrySetValue<GcNGuiLayoutData>(value);
	}

	public GcNGuiPreset(long address) : base(address)
	{

	}
}
