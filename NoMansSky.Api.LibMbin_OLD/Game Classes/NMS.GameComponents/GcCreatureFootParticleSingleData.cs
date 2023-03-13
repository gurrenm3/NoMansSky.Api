using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFootParticleSingleData : NMSTemplate
{
	public NMSString0x10 EffectName
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinCreatureSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCreatureSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureFootParticleSingleData.MoveSpeedEnum MoveSpeed
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureFootParticleSingleData.MoveSpeedEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureFootParticleSingleData.MoveSpeedEnum>(value);
	}

	public GcCreatureFootParticleSingleData(long address) : base(address)
	{

	}
}
