using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterCustomisationData : NMSTemplate
{
	public VirtualList<NMSString0x10> DescriptorGroups
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcCharacterCustomisationColourData> Colours
	{
		get => cache.GetOrAddValue(new VirtualList<GcCharacterCustomisationColourData>(address + GetOffset()));
		set => TrySetValue<GcCharacterCustomisationColourData>(value);
	}

	public VirtualList<GcCharacterCustomisationTextureOptionData> TextureOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcCharacterCustomisationTextureOptionData>(address + GetOffset()));
		set => TrySetValue<GcCharacterCustomisationTextureOptionData>(value);
	}

	public VirtualList<GcCharacterCustomisationBoneScaleData> BoneScales
	{
		get => cache.GetOrAddValue(new VirtualList<GcCharacterCustomisationBoneScaleData>(address + GetOffset()));
		set => TrySetValue<GcCharacterCustomisationBoneScaleData>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCharacterCustomisationData(long address) : base(address)
	{

	}
}
