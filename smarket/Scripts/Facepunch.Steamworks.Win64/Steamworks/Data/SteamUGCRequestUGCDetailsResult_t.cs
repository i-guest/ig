using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 9792)]
	internal struct SteamUGCRequestUGCDetailsResult_t : ICallbackData
	{
		internal SteamUGCDetails_t Details;

		internal bool CachedData;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
