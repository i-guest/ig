using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct SteamServerConnectFailure_t : ICallbackData
	{
		internal Result Result;

		internal bool StillRetrying;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
