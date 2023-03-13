using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkControllerSpecification : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkButtonImageLookup ButtonImageLookup
	{
		get => GetValue<TkButtonImageLookup>();
		set => TrySetValue<TkButtonImageLookup>(value);
	}

	public TkAxisImageLookup AxisImageLookup
	{
		get => GetValue<TkAxisImageLookup>();
		set => TrySetValue<TkAxisImageLookup>(value);
	}

	public TkChordsImageLookup ChordsImageLookup
	{
		get => GetValue<TkChordsImageLookup>();
		set => TrySetValue<TkChordsImageLookup>(value);
	}

	public TkControllerSpecification(long address) : base(address)
	{

	}
}
