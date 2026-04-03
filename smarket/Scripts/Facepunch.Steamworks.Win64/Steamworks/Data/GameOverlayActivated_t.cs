using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
	internal struct GameOverlayActivated_t : ICallbackData
	{
		internal byte Active;

		internal bool UserInitiated;

		internal AppId AppID;

		internal uint DwOverlayPID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
