using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionDof : NMSTemplate
{
	public Boolean IsEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseGlobals
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single NearPlaneMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearPlaneAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInteractionDof(long address) : base(address)
	{

	}
}
