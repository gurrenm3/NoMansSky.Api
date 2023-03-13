using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectiveTextFormatOptions : NMSTemplate
{
	public Boolean ObjectivesCanBeFormattedBySequences
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A FormattableObjective
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A FormattableObjectiveTip
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcObjectiveTextFormatOptions(long address) : base(address)
	{

	}
}
