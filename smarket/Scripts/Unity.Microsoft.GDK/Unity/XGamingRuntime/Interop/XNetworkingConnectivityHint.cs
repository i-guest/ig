namespace Unity.XGamingRuntime.Interop
{
	internal struct XNetworkingConnectivityHint
	{
		internal XNetworkingConnectivityLevelHint connectivityLevel;

		internal XNetworkingConnectivityCostHint connectivityCost;

		internal uint ianaInterfaceType;

		internal bool networkInitialized;

		internal bool approachingDataLimit;

		internal bool overDataLimit;

		internal bool roaming;
	}
}
