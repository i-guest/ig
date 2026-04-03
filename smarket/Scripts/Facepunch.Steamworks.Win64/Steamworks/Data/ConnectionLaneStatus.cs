using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 64)]
	public struct ConnectionLaneStatus
	{
		internal int cbPendingUnreliable;

		internal int cbPendingReliable;

		internal int cbSentUnackedReliable;

		internal int _reservePad1;

		internal long ecQueueTime;

		internal uint[] reserved;

		public int PendingUnreliable => 0;

		public int PendingReliable => 0;

		public int SentUnackedReliable => 0;
	}
}
