using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XNetworkingTcpQueuedReceivedBufferUsageStatistics
	{
		internal Unity.XGamingRuntime.Interop.XNetworkingTcpQueuedReceivedBufferUsageStatistics interop;

		public ulong NumBytesCurrentlyQueued
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong PeakNumBytesEverQueued
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong TotalNumBytesQueued
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong NumBytesDroppedForExceedingConfiguredMax
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong NumBytesDroppedDueToAnyFailure
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XNetworkingTcpQueuedReceivedBufferUsageStatistics(Unity.XGamingRuntime.Interop.XNetworkingTcpQueuedReceivedBufferUsageStatistics interop)
		{
		}

		public XNetworkingTcpQueuedReceivedBufferUsageStatistics()
		{
		}
	}
}
