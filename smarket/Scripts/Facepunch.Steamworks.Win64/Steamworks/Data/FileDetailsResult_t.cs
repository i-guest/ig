using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
	internal struct FileDetailsResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong FileSize;

		internal byte[] FileSHA;

		internal uint Flags;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
