using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 1024)]
	internal struct SteamRemotePlayTogetherGuestInvite_t : ICallbackData
	{
		internal byte[] ConnectURL;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string ConnectURLUTF8()
		{
			return null;
		}
	}
}
