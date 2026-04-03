using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct HTML_JSConfirm_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchMessage;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
