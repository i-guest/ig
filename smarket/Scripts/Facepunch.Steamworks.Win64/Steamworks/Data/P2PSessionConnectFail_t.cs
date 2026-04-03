using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct P2PSessionConnectFail_t : ICallbackData
	{
		internal ulong SteamIDRemote;

		internal byte P2PSessionError;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
