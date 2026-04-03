using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct ClientGameServerDeny_t : ICallbackData
	{
		internal uint AppID;

		internal uint GameServerIP;

		internal ushort GameServerPort;

		internal ushort Secure;

		internal uint Reason;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
