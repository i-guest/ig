namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionMemberRole
	{
		internal UTF8StringPtr roleTypeName;

		internal UTF8StringPtr roleName;

		internal XblMultiplayerSessionMemberRole(Unity.XGamingRuntime.XblMultiplayerSessionMemberRole publicObject, DisposableCollection disposableCollection)
		{
			roleTypeName = default(UTF8StringPtr);
			roleName = default(UTF8StringPtr);
		}
	}
}
