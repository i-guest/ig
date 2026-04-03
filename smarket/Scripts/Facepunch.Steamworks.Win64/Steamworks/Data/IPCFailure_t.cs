using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 1)]
	internal struct IPCFailure_t : ICallbackData
	{
		internal enum EFailureType
		{
			FlushedCallbackQueue = 0,
			PipeFail = 1
		}

		internal byte FailureType;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
