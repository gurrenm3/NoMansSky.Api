using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBasePartSearchFilter : NMSTemplate
{
	public NMSString0x10 IsSpecificID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean PartIsOnline
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PartIsNotOnline
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PartIsVision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PartIsNotVision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyGridFilter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBaseGridSearchFilter BaseGridFilter
	{
		get => GetValue<GcBaseGridSearchFilter>();
		set => TrySetValue<GcBaseGridSearchFilter>(value);
	}

	public GcBasePartSearchFilter(long address) : base(address)
	{

	}
}
