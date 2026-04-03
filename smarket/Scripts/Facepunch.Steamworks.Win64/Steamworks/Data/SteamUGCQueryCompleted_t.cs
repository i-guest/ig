using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 280)]
	internal struct SteamUGCQueryCompleted_t : ICallbackData
	{
		internal ulong Handle;

		internal Result Result;

		internal uint NumResultsReturned;

		internal uint TotalMatchingResults;

		internal bool CachedData;

		internal byte[] NextCursor;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string NextCursorUTF8()
		{
			return null;
		}
	}
}
