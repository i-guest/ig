using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct GSReputation_t : ICallbackData
	{
		internal Result Result;

		internal uint ReputationScore;

		internal bool Banned;

		internal uint BannedIP;

		internal ushort BannedPort;

		internal ulong BannedGameID;

		internal uint BanExpires;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
