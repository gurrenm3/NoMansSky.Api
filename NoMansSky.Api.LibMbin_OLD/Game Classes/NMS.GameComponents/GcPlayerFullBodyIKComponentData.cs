using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerFullBodyIKComponentData : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableFootRaycasts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcIKConstraint> HeadConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcIKConstraint>(address + GetOffset()));
		set => TrySetValue<GcIKConstraint>(value);
	}

	public VirtualList<GcIKConstraint> LegConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcIKConstraint>(address + GetOffset()));
		set => TrySetValue<GcIKConstraint>(value);
	}

	public GcIKConstraint COGConstraint
	{
		get => GetValue<GcIKConstraint>();
		set => TrySetValue<GcIKConstraint>(value);
	}

	public VirtualList<GcIKConstraint> RestrictConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcIKConstraint>(address + GetOffset()));
		set => TrySetValue<GcIKConstraint>(value);
	}

	public VirtualList<NMSString0x20> HandBones
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> CameraNeckBones
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcIKConstraint SitConstraint
	{
		get => GetValue<GcIKConstraint>();
		set => TrySetValue<GcIKConstraint>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerFullBodyIKComponentData.PlayerHeadUpAxisEnum PlayerHeadUpAxis
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerFullBodyIKComponentData.PlayerHeadUpAxisEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerFullBodyIKComponentData.PlayerHeadUpAxisEnum>(value);
	}

	public VirtualList<GcCreatureIkData> JointDataDeprecated
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureIkData>(address + GetOffset()));
		set => TrySetValue<GcCreatureIkData>(value);
	}

	public Boolean UseFootGlue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCharacterLookAtData LookAtSettings
	{
		get => GetValue<GcCharacterLookAtData>();
		set => TrySetValue<GcCharacterLookAtData>(value);
	}

	public GcPlayerFullBodyIKComponentData(long address) : base(address)
	{

	}
}
