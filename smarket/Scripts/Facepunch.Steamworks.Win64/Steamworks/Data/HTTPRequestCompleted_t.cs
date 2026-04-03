using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct HTTPRequestCompleted_t : ICallbackData
	{
		internal uint Request;

		internal ulong ContextValue;

		internal bool RequestSuccessful;

		internal HTTPStatusCode StatusCode;

		internal uint BodySize;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
