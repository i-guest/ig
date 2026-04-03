using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 136)]
	internal struct SteamNetworkingMessagesSessionRequest_t : ICallbackData
	{
		internal NetIdentity DentityRemote;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
