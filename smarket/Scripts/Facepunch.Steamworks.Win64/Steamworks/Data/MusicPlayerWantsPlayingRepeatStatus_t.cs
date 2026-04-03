using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
	internal struct MusicPlayerWantsPlayingRepeatStatus_t : ICallbackData
	{
		internal int PlayingRepeatStatus;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
