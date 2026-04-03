using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 24)]
	internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData
	{
		internal Result Result;

		internal int CPlayersThatDontLikeCandidate;

		internal int CPlayersThatCandidateDoesntLike;

		internal int CClanPlayersThatDontLikeCandidate;

		internal ulong SteamIDCandidate;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
