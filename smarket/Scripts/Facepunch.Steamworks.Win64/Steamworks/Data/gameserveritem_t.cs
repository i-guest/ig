using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 372)]
	internal struct gameserveritem_t
	{
		internal servernetadr_t NetAdr;

		internal int Ping;

		internal bool HadSuccessfulResponse;

		internal bool DoNotRefresh;

		internal byte[] GameDir;

		internal byte[] Map;

		internal byte[] GameDescription;

		internal uint AppID;

		internal int Players;

		internal int MaxPlayers;

		internal int BotPlayers;

		internal bool Password;

		internal bool Secure;

		internal uint TimeLastPlayed;

		internal int ServerVersion;

		internal byte[] ServerName;

		internal byte[] GameTags;

		internal ulong SteamID;

		[PreserveSig]
		internal static extern void InternalConstruct(ref gameserveritem_t self);

		[PreserveSig]
		internal static extern Utf8StringPointer InternalGetName(ref gameserveritem_t self);

		[PreserveSig]
		internal static extern void InternalSetName(ref gameserveritem_t self, string pName);

		internal string GameDirUTF8()
		{
			return null;
		}

		internal string MapUTF8()
		{
			return null;
		}

		internal string GameDescriptionUTF8()
		{
			return null;
		}

		internal string ServerNameUTF8()
		{
			return null;
		}

		internal string GameTagsUTF8()
		{
			return null;
		}
	}
}
