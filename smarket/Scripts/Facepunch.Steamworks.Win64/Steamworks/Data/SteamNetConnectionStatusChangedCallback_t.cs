using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 712)]
	internal struct SteamNetConnectionStatusChangedCallback_t : ICallbackData
	{
		internal Connection Conn;

		internal ConnectionInfo Nfo;

		internal ConnectionState OldState;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
