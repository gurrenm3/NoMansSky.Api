using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealityGameIcons : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRealityGameIcons.GameIconsEnum GameIcons
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRealityGameIcons.GameIconsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRealityGameIcons.GameIconsEnum>(value);
	}

	public GcRealityGameIcons(long address) : base(address)
	{

	}
}
