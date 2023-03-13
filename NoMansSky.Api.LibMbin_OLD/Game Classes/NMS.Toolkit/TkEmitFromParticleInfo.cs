using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEmitFromParticleInfo : NMSTemplate
{
	public Int32 OtherEmitterIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.Toolkit.TkEmitFromParticleInfo.EmissionRateTypeEnum EmissionRateType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkEmitFromParticleInfo.EmissionRateTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkEmitFromParticleInfo.EmissionRateTypeEnum>(value);
	}

	public TkEmitFromParticleInfo(long address) : base(address)
	{

	}
}
