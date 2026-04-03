namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerPeerToPeerRequirements
	{
		internal readonly ulong LatencyMaximum;

		internal readonly ulong BandwidthMinimumInKbps;

		internal XblMultiplayerPeerToPeerRequirements(Unity.XGamingRuntime.XblMultiplayerPeerToPeerRequirements publicObject)
		{
			LatencyMaximum = 0uL;
			BandwidthMinimumInKbps = 0uL;
		}
	}
}
