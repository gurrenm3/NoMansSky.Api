using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatIcons : NMSTemplate
{
	public VirtualArray<TkTextureResource> Icons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 18));
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource SawTooth
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource Sine
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource Square
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource Triangle
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcByteBeatIcons(long address) : base(address)
	{

	}
}
