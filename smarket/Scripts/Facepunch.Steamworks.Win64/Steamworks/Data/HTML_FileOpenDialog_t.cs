using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct HTML_FileOpenDialog_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchTitle;

		internal string PchInitialFile;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
