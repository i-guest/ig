namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerActivityRecentPlayerUpdate
	{
		internal readonly ulong xuid;

		internal readonly XblMultiplayerActivityEncounterType encounterType;

		internal XblMultiplayerActivityRecentPlayerUpdate(Unity.XGamingRuntime.XblMultiplayerActivityRecentPlayerUpdate publicObject)
		{
			xuid = 0uL;
			encounterType = default(XblMultiplayerActivityEncounterType);
		}
	}
}
