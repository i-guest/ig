using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct SetPersonaNameResponse_t : ICallbackData
	{
		internal bool Success;

		internal bool LocalSuccess;

		internal Result Result;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
