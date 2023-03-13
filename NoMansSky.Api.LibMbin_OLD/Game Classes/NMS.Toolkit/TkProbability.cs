using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProbability : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkProbability.ProbabilityEnum Probability
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkProbability.ProbabilityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkProbability.ProbabilityEnum>(value);
	}

	public TkProbability(long address) : base(address)
	{

	}
}
