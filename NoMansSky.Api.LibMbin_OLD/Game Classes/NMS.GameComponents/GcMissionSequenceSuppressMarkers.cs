using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceSuppressMarkers : NMSTemplate
{
	public Boolean Suppressed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SuppressedAfterNextWarp
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionSequenceSuppressMarkers(long address) : base(address)
	{

	}
}
