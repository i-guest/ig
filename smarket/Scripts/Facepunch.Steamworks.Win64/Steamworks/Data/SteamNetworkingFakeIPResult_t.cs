using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 160)]
	internal struct SteamNetworkingFakeIPResult_t : ICallbackData
	{
		internal Result Result;

		internal NetIdentity Dentity;

		internal uint IP;

		internal ushort[] Ports;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
