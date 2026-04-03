using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct SteamInventoryStartPurchaseResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong OrderID;

		internal ulong TransID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
