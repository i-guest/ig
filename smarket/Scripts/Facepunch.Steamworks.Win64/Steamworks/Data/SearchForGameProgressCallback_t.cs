using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 36)]
	internal struct SearchForGameProgressCallback_t : ICallbackData
	{
		internal ulong LSearchID;

		internal Result Result;

		internal ulong LobbyID;

		internal ulong SteamIDEndedSearch;

		internal int SecondsRemainingEstimate;

		internal int CPlayersSearching;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
