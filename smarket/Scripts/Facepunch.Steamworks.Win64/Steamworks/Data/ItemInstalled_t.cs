using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct ItemInstalled_t : ICallbackData
	{
		internal AppId AppID;

		internal PublishedFileId PublishedFileId;

		internal ulong LegacyContent;

		internal ulong ManifestID;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
