using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSceneNodeData : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public UInt32 NameHash
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public NMSString0x10 Type
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkTransformData Transform
	{
		get => GetValue<TkTransformData>();
		set => TrySetValue<TkTransformData>(value);
	}

	public VirtualList<TkSceneNodeAttributeData> Attributes
	{
		get => cache.GetOrAddValue(new VirtualList<TkSceneNodeAttributeData>(address + GetOffset()));
		set => TrySetValue<TkSceneNodeAttributeData>(value);
	}

	public VirtualList<TkSceneNodeData> Children
	{
		get => cache.GetOrAddValue(new VirtualList<TkSceneNodeData>(address + GetOffset()));
		set => TrySetValue<TkSceneNodeData>(value);
	}

	public TkSceneNodeData(long address) : base(address)
	{

	}
}
