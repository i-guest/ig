using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct SteamAPICallCompleted_t : ICallbackData
	{
		internal ulong AsyncCall;

		internal int Callback;

		internal uint ParamCount;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
