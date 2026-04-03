using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 252)]
	internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData
	{
		internal Result Result;

		internal uint AppID;

		internal uint CchKeyLength;

		internal byte[] Key;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string KeyUTF8()
		{
			return null;
		}
	}
}
