using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct SetUserItemVoteResult_t : ICallbackData
	{
		internal PublishedFileId PublishedFileId;

		internal Result Result;

		internal bool VoteUp;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
