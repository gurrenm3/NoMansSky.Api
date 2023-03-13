using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCFace : NMSTemplate
{
	public NMSString0x20 Connector
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean Symmetric
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCFace.TransformEnum Transform
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCFace.TransformEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCFace.TransformEnum>(value);
	}

	public VirtualList<NMSString0x10> ExcludedNeighboursR0
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ExcludedNeighboursR1
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ExcludedNeighboursR2
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ExcludedNeighboursR3
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Walkable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Incomplete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsEntrance
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcWFCFace(long address) : base(address)
	{

	}
}
