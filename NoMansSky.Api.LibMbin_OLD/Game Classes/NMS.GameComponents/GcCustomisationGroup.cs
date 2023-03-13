using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationGroup : NMSTemplate
{
	public NMSString0x10 GroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A GroupTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsBannerGroup
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceShowAllColourOptions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCustomisationCameraData CameraData
	{
		get => GetValue<GcCustomisationCameraData>();
		set => TrySetValue<GcCustomisationCameraData>(value);
	}

	public VirtualList<GcCustomisationDescriptorGroupOptions> DescriptorOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationDescriptorGroupOptions>(address + GetOffset()));
		set => TrySetValue<GcCustomisationDescriptorGroupOptions>(value);
	}

	public VirtualList<GcCustomisationTextureGroup> TextureGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationTextureGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationTextureGroup>(value);
	}

	public VirtualList<GcCustomisationColourGroup> ColourGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationColourGroup>(address + GetOffset()));
		set => TrySetValue<GcCustomisationColourGroup>(value);
	}

	public VirtualList<GcCustomisationBoneScales> BoneScales
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationBoneScales>(address + GetOffset()));
		set => TrySetValue<GcCustomisationBoneScales>(value);
	}

	public GcCustomisationGroup(long address) : base(address)
	{

	}
}
