using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 696)]
	internal struct SteamNetworkingMessagesSessionFailed_t : ICallbackData
	{
		internal ConnectionInfo Nfo;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
