using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 9760)]
	internal struct RemoteStorageGetPublishedFileDetailsResult_t : ICallbackData
	{
		internal Result Result;

		internal PublishedFileId PublishedFileId;

		internal AppId CreatorAppID;

		internal AppId ConsumerAppID;

		internal byte[] Title;

		internal byte[] Description;

		internal ulong File;

		internal ulong PreviewFile;

		internal ulong SteamIDOwner;

		internal uint TimeCreated;

		internal uint TimeUpdated;

		internal RemoteStoragePublishedFileVisibility Visibility;

		internal bool Banned;

		internal byte[] Tags;

		internal bool TagsTruncated;

		internal byte[] PchFileName;

		internal int FileSize;

		internal int PreviewFileSize;

		internal byte[] URL;

		internal WorkshopFileType FileType;

		internal bool AcceptedForUse;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);

		internal string TitleUTF8()
		{
			return null;
		}

		internal string DescriptionUTF8()
		{
			return null;
		}

		internal string TagsUTF8()
		{
			return null;
		}

		internal string PchFileNameUTF8()
		{
			return null;
		}

		internal string URLUTF8()
		{
			return null;
		}
	}
}
