using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLODModelResource : NMSTemplate
{
	public TkModelResource LODModel
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwapThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkLODModelResource(long address) : base(address)
	{

	}
}
