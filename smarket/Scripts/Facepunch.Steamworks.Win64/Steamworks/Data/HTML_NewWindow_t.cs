using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct HTML_NewWindow_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal uint UnX;

		internal uint UnY;

		internal uint UnWide;

		internal uint UnTall;

		internal uint UnNewWindow_BrowserHandle_IGNORE;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
