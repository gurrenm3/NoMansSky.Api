using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiSpecialTextImageData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ScaleToFitFont
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f Size
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSString0x80 Path
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcNGuiSpecialTextImageData(long address) : base(address)
	{

	}
}
