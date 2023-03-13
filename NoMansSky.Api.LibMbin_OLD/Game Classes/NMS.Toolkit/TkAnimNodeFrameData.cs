using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimNodeFrameData : NMSTemplate
{
	public VirtualList<Quaternion> Rotations
	{
		get => cache.GetOrAddValue(new VirtualList<Quaternion>(address + GetOffset()));
		set => TrySetValue<Quaternion>(value);
	}

	public VirtualList<Vector3f> Translations
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<Vector3f> Scales
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public TkAnimNodeFrameData(long address) : base(address)
	{

	}
}
