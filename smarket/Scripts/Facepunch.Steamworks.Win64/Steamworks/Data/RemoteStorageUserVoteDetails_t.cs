using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
	internal struct RemoteStorageUserVoteDetails_t : ICallbackData
	{
		internal Result Result;

		internal PublishedFileId PublishedFileId;

		internal WorkshopVote Vote;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
