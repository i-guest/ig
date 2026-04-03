using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 88)]
	internal struct SteamTimelineGamePhaseRecordingExists_t : ICallbackData
	{
		internal byte[] PhaseID;

		internal ulong RecordingMS;

		internal ulong LongestClipMS;

		internal uint ClipCount;

		internal uint ScreenshotCount;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string PhaseIDUTF8()
		{
			return null;
		}
	}
}
