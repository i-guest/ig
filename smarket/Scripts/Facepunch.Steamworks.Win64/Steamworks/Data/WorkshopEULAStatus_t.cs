using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
	internal struct WorkshopEULAStatus_t : ICallbackData
	{
		internal Result Result;

		internal AppId AppID;

		internal uint Version;

		internal uint TAction;

		internal bool Accepted;

		internal bool NeedsAction;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
