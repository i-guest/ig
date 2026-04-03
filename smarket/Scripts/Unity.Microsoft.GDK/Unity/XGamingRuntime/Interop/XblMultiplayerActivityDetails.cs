namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerActivityDetails
	{
		internal XblMultiplayerSessionReference SessionReference;

		internal byte[] HandleId;

		internal uint TitleId;

		internal XblMultiplayerSessionVisibility Visibility;

		internal XblMultiplayerSessionRestriction JoinRestriction;

		internal bool Closed;

		internal ulong OwnerXuid;

		internal uint MaxMembersCount;

		internal uint MembersCount;

		internal UTF8StringPtr CustomSessionPropertiesJson;

		internal string GetHandleId()
		{
			return null;
		}
	}
}
