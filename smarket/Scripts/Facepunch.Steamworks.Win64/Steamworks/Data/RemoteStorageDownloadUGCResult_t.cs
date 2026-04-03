using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 296)]
	internal struct RemoteStorageDownloadUGCResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong File;

		internal AppId AppID;

		internal int SizeInBytes;

		internal byte[] PchFileName;

		internal ulong SteamIDOwner;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string PchFileNameUTF8()
		{
			return null;
		}
	}
}
