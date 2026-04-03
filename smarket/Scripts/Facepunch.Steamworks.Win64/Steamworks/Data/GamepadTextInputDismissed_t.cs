using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
	internal struct GamepadTextInputDismissed_t : ICallbackData
	{
		internal bool Submitted;

		internal uint SubmittedText;

		internal AppId AppID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
