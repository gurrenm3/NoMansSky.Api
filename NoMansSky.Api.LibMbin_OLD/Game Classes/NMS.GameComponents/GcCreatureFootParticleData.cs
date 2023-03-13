using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFootParticleData : NMSTemplate
{
	public VirtualList<GcCreatureFootParticleSingleData> ParticleData
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureFootParticleSingleData>(address + GetOffset()));
		set => TrySetValue<GcCreatureFootParticleSingleData>(value);
	}

	public GcCreatureFootParticleData(long address) : base(address)
	{

	}
}
