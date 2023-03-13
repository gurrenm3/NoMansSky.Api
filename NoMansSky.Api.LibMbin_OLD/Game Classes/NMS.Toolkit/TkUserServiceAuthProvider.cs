using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkUserServiceAuthProvider : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkUserServiceAuthProvider.AuthProviderEnum AuthProvider
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkUserServiceAuthProvider.AuthProviderEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkUserServiceAuthProvider.AuthProviderEnum>(value);
	}

	public TkUserServiceAuthProvider(long address) : base(address)
	{

	}
}
