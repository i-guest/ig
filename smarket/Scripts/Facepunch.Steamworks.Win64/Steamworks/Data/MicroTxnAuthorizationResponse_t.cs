using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct MicroTxnAuthorizationResponse_t : ICallbackData
	{
		internal uint AppID;

		internal ulong OrderID;

		internal byte Authorized;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
