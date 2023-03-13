using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAdvancedTweaks : NMSTemplate
{
	public Single ParticleKillSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleKillSpeedWrtFixed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EdgeMultiplierForTangentI
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EdgeMultiplierForTangentJ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RenderNormalMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StretchUvsToHideTextureEdges
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAdvancedTweaks(long address) : base(address)
	{

	}
}
