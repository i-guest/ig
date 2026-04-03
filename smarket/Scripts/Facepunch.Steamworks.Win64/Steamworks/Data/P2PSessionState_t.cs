using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
	internal struct P2PSessionState_t
	{
		internal byte ConnectionActive;

		internal byte Connecting;

		internal byte P2PSessionError;

		internal byte UsingRelay;

		internal int BytesQueuedForSend;

		internal int PacketsQueuedForSend;

		internal uint RemoteIP;

		internal ushort RemotePort;
	}
}
