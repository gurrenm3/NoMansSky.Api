using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyInfoIcons : NMSTemplate
{
	public VirtualArray<TkTextureResource> RaceIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 8));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> EconomyIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource EconomyTechNotInstalledIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> WealthIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 4));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> ConflictIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 4));
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource ConflictTechNotInstalledIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource WarpIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource WarpErrorIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource WarpTechNotInstalledIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcGalaxyInfoIcons(long address) : base(address)
	{

	}
}
