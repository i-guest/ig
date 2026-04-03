using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct RemoteStorageFileReadAsyncComplete_t : ICallbackData
	{
		internal ulong FileReadAsync;

		internal Result Result;

		internal uint Offset;

		internal uint Read;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
