using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 256)]
	internal struct GameWebCallback_t : ICallbackData
	{
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
