using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCNavSubgraphNodeTypeConnectivity : NMSTemplate
{
	public Single InternalConnection
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExternalConnection
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathToPOI
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConnectionToPOI
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCNavSubgraphNodeTypeConnectivity(long address) : base(address)
	{

	}
}
