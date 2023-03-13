using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCModuleSet : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Vector3f BlockSize
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean ApplyWallThemes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcWFCModulePrototype> ModulePrototypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWFCModulePrototype>(address + GetOffset()));
		set => TrySetValue<GcWFCModulePrototype>(value);
	}

	public VirtualList<NMSString0x20> ConnectorsOnUpperBoundary
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> ConnectorsOnLowerBoundary
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> ConnectorsOnHorizontalBoundary
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x10> DefaultGroups
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcIDPair> CompatibleConnectors
	{
		get => cache.GetOrAddValue(new VirtualList<GcIDPair>(address + GetOffset()));
		set => TrySetValue<GcIDPair>(value);
	}

	public Single VerticalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWFCModuleSet(long address) : base(address)
	{

	}
}
