using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 20)]
	internal struct UserStatsReceived_t : ICallbackData
	{
		internal ulong GameID;

		internal Result Result;

		internal ulong SteamIDUser;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
