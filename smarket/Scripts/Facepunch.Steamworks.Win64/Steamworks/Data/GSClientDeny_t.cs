using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 144)]
	internal struct GSClientDeny_t : ICallbackData
	{
		internal ulong SteamID;

		internal DenyReason DenyReason;

		internal byte[] OptionalText;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string OptionalTextUTF8()
		{
			return null;
		}
	}
}
