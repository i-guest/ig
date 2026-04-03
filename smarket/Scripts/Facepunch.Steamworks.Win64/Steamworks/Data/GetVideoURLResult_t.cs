using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 264)]
	internal struct GetVideoURLResult_t : ICallbackData
	{
		internal Result Result;

		internal AppId VideoAppID;

		internal byte[] URL;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string URLUTF8()
		{
			return null;
		}
	}
}
