using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct HTTPRequestDataReceived_t : ICallbackData
	{
		internal uint Request;

		internal ulong ContextValue;

		internal uint COffset;

		internal uint CBytesReceived;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
