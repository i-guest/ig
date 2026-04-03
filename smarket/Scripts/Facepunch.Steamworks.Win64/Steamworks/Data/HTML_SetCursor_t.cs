using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct HTML_SetCursor_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal uint EMouseCursor;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
