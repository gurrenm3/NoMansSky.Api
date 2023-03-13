using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationUIData : NMSTemplate
{
	public VirtualArray<GcCustomisationUI> CustomisationUIData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCustomisationUI>(address + GetOffset(), 20));
		set => TrySetValue<GcCustomisationUI>(value);
	}

	public GcCustomisationUIData(long address) : base(address)
	{

	}
}
