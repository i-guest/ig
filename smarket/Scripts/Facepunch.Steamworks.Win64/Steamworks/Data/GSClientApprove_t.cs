using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 16)]
	internal struct GSClientApprove_t : ICallbackData
	{
		internal ulong SteamID;

		internal ulong OwnerSteamID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
