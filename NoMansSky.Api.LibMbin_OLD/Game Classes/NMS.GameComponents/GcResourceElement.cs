using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcResourceElement : NMSTemplate
{
	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcResource ResHandle
	{
		get => GetValue<GcResource>();
		set => TrySetValue<GcResource>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x200 AltId
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public TkProceduralTextureChosenOptionList ProceduralTexture
	{
		get => GetValue<TkProceduralTextureChosenOptionList>();
		set => TrySetValue<TkProceduralTextureChosenOptionList>(value);
	}

	public GcResourceElement(long address) : base(address)
	{

	}
}
