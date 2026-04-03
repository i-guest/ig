using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct GetUserItemVoteResult_t : ICallbackData
	{
		internal PublishedFileId PublishedFileId;

		internal Result Result;

		internal bool VotedUp;

		internal bool VotedDown;

		internal bool VoteSkipped;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
