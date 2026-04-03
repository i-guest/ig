using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 28)]
	internal struct FavoritesListChanged_t : ICallbackData
	{
		internal uint IP;

		internal uint QueryPort;

		internal uint ConnPort;

		internal uint AppID;

		internal uint Flags;

		internal bool Add;

		internal uint AccountId;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
