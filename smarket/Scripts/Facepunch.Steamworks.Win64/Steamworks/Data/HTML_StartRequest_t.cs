using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct HTML_StartRequest_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal string PchTarget;

		internal string PchPostData;

		internal bool BIsRedirect;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
