namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerPeerToHostRequirements
	{
		internal readonly ulong LatencyMaximum;

		internal readonly ulong BandwidthDownMinimumInKbps;

		internal readonly ulong BandwidthUpMinimumInKbps;

		internal readonly XblMultiplayerMetrics HostSelectionMetric;

		internal XblMultiplayerPeerToHostRequirements(Unity.XGamingRuntime.XblMultiplayerPeerToHostRequirements publicObject)
		{
			LatencyMaximum = 0uL;
			BandwidthDownMinimumInKbps = 0uL;
			BandwidthUpMinimumInKbps = 0uL;
			HostSelectionMetric = default(XblMultiplayerMetrics);
		}
	}
}
