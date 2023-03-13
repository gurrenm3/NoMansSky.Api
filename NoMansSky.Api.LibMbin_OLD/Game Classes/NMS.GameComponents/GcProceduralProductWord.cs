using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralProductWord : NMSTemplate
{
	public GcNameGeneratorWord Word
	{
		get => GetValue<GcNameGeneratorWord>();
		set => TrySetValue<GcNameGeneratorWord>(value);
	}

	public GcNameGeneratorWord UncommonWord
	{
		get => GetValue<GcNameGeneratorWord>();
		set => TrySetValue<GcNameGeneratorWord>(value);
	}

	public GcNameGeneratorWord RareWord
	{
		get => GetValue<GcNameGeneratorWord>();
		set => TrySetValue<GcNameGeneratorWord>(value);
	}

	public NMSString0x20 ReplaceKey
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcProceduralProductWord(long address) : base(address)
	{

	}
}
