using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct DurationControl_t : ICallbackData
	{
		internal Result Result;

		internal AppId Appid;

		internal bool Applicable;

		internal int CsecsLast5h;

		internal DurationControlProgress Progress;

		internal DurationControlNotification Otification;

		internal int CsecsToday;

		internal int CsecsRemaining;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
