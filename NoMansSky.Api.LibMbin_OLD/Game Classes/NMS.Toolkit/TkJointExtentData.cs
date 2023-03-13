using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkJointExtentData : NMSTemplate
{
	public VirtualArray<Single> JointExtentMin
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> JointExtentMax
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> JointExtentCenter
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> JointExtentStdDev
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 3));
		set => TrySetValue<Single>(value);
	}

	public TkJointExtentData(long address) : base(address)
	{

	}
}
