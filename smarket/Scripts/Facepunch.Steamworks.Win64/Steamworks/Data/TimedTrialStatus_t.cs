using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct TimedTrialStatus_t : ICallbackData
	{
		internal AppId AppID;

		internal bool IsOffline;

		internal uint SecondsAllowed;

		internal uint SecondsPlayed;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
