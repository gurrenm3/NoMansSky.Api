using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasFeaturedBaseStateChange : NMSTemplate
{
	public Boolean Dev
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean QA
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Prod
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 Platform
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x40 BaseId
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcAtlasFeaturedBaseStateChange(long address) : base(address)
	{

	}
}
