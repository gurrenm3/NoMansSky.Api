using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkJointBindingData : NMSTemplate
{
	public VirtualArray<Single> InvBindMatrix
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 16));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> BindTranslate
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> BindRotate
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> BindScale
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public TkJointBindingData(long address) : base(address)
	{

	}
}
