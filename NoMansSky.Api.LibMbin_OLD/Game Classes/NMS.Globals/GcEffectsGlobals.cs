using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEffectsGlobals : NMSTemplate
{
	public Single ClickToPlayScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClickToPlayCameraOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelRendererData ResourceRendererData
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public GcEffectsGlobals(long address) : base(address)
	{

	}
}
