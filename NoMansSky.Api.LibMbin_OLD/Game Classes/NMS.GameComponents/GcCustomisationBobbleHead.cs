using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationBobbleHead : NMSTemplate
{
	public NMSString0x10 LinkedTechId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkModelResource BobbleHead
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcCustomisationBobbleHead(long address) : base(address)
	{

	}
}
