using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 280)]
	internal struct RemoteStorageFileShareResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong File;

		internal byte[] Filename;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string FilenameUTF8()
		{
			return null;
		}
	}
}
