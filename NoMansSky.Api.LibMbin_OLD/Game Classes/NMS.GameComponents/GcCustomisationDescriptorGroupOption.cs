using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationDescriptorGroupOption : NMSTemplate
{
	public NMSString0x10 DescriptorOption
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcCustomisationTextureGroup> TextureGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationTextureGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationTextureGroup>(value);
	}

	public Boolean ReplaceBaseColours
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCustomisationColourGroup> ColourGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationColourGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationColourGroup>(value);
	}

	public Boolean ReplaceBaseBoneScales
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCustomisationBoneScales> BoneScales
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationBoneScales>(address + GetOffset()));
		set => TrySetValue<GcCustomisationBoneScales>(value);
	}

	public Int32 InteractionCameraIndexOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 InteracttionCameraFocusJointOverride
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x10> HideIfGroupActive
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SelectingRemovesGroup
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SelectingAddsGroup
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnselectingRemovesGroup
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnselectingAddsGroup
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCustomisationDescriptorGroupOption(long address) : base(address)
	{

	}
}
