using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XNetworkingStatisticsBuffer
	{
		internal Unity.XGamingRuntime.Interop.XNetworkingStatisticsBuffer _interop;

		internal XNetworkingTcpQueuedReceivedBufferUsageStatistics _tcpQueuedReceivedBufferUsageStatistics;

		internal Unity.XGamingRuntime.Interop.XNetworkingStatisticsBuffer interop => default(Unity.XGamingRuntime.Interop.XNetworkingStatisticsBuffer);

		public XNetworkingTcpQueuedReceivedBufferUsageStatistics TcpQueuedReceiveBufferUsage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XNetworkingStatisticsBuffer(Unity.XGamingRuntime.Interop.XNetworkingStatisticsBuffer interop)
		{
		}

		public XNetworkingStatisticsBuffer()
		{
		}
	}
}
