using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 128)]
	internal struct GameServerChangeRequested_t : ICallbackData
	{
		internal byte[] Server;

		internal byte[] Password;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string ServerUTF8()
		{
			return null;
		}

		internal string PasswordUTF8()
		{
			return null;
		}
	}
}
