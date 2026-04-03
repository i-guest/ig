using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 276)]
	internal struct JoinPartyCallback_t : ICallbackData
	{
		internal Result Result;

		internal ulong BeaconID;

		internal ulong SteamIDBeaconOwner;

		internal byte[] ConnectString;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string ConnectStringUTF8()
		{
			return null;
		}
	}
}
