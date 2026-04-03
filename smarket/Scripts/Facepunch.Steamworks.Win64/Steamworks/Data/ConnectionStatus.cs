using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 120)]
	public struct ConnectionStatus
	{
		internal ConnectionState state;

		internal int ping;

		internal float connectionQualityLocal;

		internal float connectionQualityRemote;

		internal float outPacketsPerSec;

		internal float outBytesPerSec;

		internal float inPacketsPerSec;

		internal float inBytesPerSec;

		internal int sendRateBytesPerSecond;

		internal int cbPendingUnreliable;

		internal int cbPendingReliable;

		internal int cbSentUnackedReliable;

		internal long ecQueueTime;

		internal uint[] reserved;

		public int Ping => 0;

		public float OutPacketsPerSec => 0f;

		public float OutBytesPerSec => 0f;

		public float InPacketsPerSec => 0f;

		public float InBytesPerSec => 0f;

		public float ConnectionQualityLocal => 0f;

		public float ConnectionQualityRemote => 0f;

		public int PendingUnreliable => 0;

		public int PendingReliable => 0;

		public int SentUnackedReliable => 0;
	}
}
