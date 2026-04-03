using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
	internal struct DlcInstalled_t : ICallbackData
	{
		internal AppId AppID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
