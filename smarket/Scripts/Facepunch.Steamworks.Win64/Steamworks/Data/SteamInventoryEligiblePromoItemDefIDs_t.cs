using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 20)]
	internal struct SteamInventoryEligiblePromoItemDefIDs_t : ICallbackData
	{
		internal Result Result;

		internal ulong SteamID;

		internal int UmEligiblePromoItemDefs;

		internal bool CachedData;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
