using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 32)]
	internal struct SearchForGameResultCallback_t : ICallbackData
	{
		internal ulong LSearchID;

		internal Result Result;

		internal int CountPlayersInGame;

		internal int CountAcceptedGame;

		internal ulong SteamIDHost;

		internal bool FinalCallback;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
