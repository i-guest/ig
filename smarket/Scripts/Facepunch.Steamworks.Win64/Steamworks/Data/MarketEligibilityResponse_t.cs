using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
	internal struct MarketEligibilityResponse_t : ICallbackData
	{
		internal bool Allowed;

		internal MarketNotAllowedReasonFlags NotAllowedReason;

		internal uint TAllowedAtTime;

		internal int CdaySteamGuardRequiredDays;

		internal int CdayNewDeviceCooldown;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
