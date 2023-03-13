using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerIcon : NMSTemplate
{
	public TkTextureResource Main
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource Small
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcScannerIconHighlightTypes Highlight
	{
		get => GetValue<GcScannerIconHighlightTypes>();
		set => TrySetValue<GcScannerIconHighlightTypes>(value);
	}

	public GcScannerIcon(long address) : base(address)
	{

	}
}
