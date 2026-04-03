using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct AvatarImageLoaded_t : ICallbackData
	{
		internal ulong SteamID;

		internal int Image;

		internal int Wide;

		internal int Tall;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
