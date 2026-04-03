using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct ClanOfficerListResponse_t : ICallbackData
	{
		internal ulong SteamIDClan;

		internal int COfficers;

		internal byte Success;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
