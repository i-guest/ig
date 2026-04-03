using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamMusicRemote : SteamInterface
	{
		public const string Version = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		internal ISteamMusicRemote(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamMusicRemote_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _RegisterSteamMusicRemote(IntPtr self, string pchName);

		internal bool RegisterSteamMusicRemote(string pchName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _DeregisterSteamMusicRemote(IntPtr self);

		internal bool DeregisterSteamMusicRemote()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsCurrentMusicRemote(IntPtr self);

		internal bool BIsCurrentMusicRemote()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BActivationSuccess(IntPtr self, bool bValue);

		internal bool BActivationSuccess(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetDisplayName(IntPtr self, string pchDisplayName);

		internal bool SetDisplayName(string pchDisplayName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetPNGIcon_64x64(IntPtr self, IntPtr pvBuffer, uint cbBufferLength);

		internal bool SetPNGIcon_64x64(IntPtr pvBuffer, uint cbBufferLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnablePlayPrevious(IntPtr self, bool bValue);

		internal bool EnablePlayPrevious(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnablePlayNext(IntPtr self, bool bValue);

		internal bool EnablePlayNext(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnableShuffled(IntPtr self, bool bValue);

		internal bool EnableShuffled(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnableLooped(IntPtr self, bool bValue);

		internal bool EnableLooped(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnableQueue(IntPtr self, bool bValue);

		internal bool EnableQueue(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _EnablePlaylists(IntPtr self, bool bValue);

		internal bool EnablePlaylists(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdatePlaybackStatus(IntPtr self, MusicStatus nStatus);

		internal bool UpdatePlaybackStatus(MusicStatus nStatus)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateShuffled(IntPtr self, bool bValue);

		internal bool UpdateShuffled(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateLooped(IntPtr self, bool bValue);

		internal bool UpdateLooped(bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateVolume(IntPtr self, float flValue);

		internal bool UpdateVolume(float flValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CurrentEntryWillChange(IntPtr self);

		internal bool CurrentEntryWillChange()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CurrentEntryIsAvailable(IntPtr self, bool bAvailable);

		internal bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateCurrentEntryText(IntPtr self, string pchText);

		internal bool UpdateCurrentEntryText(string pchText)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateCurrentEntryElapsedSeconds(IntPtr self, int nValue);

		internal bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _UpdateCurrentEntryCoverArt(IntPtr self, IntPtr pvBuffer, uint cbBufferLength);

		internal bool UpdateCurrentEntryCoverArt(IntPtr pvBuffer, uint cbBufferLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CurrentEntryDidChange(IntPtr self);

		internal bool CurrentEntryDidChange()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _QueueWillChange(IntPtr self);

		internal bool QueueWillChange()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ResetQueueEntries(IntPtr self);

		internal bool ResetQueueEntries()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetQueueEntry(IntPtr self, int nID, int nPosition, string pchEntryText);

		internal bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetCurrentQueueEntry(IntPtr self, int nID);

		internal bool SetCurrentQueueEntry(int nID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _QueueDidChange(IntPtr self);

		internal bool QueueDidChange()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _PlaylistWillChange(IntPtr self);

		internal bool PlaylistWillChange()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ResetPlaylistEntries(IntPtr self);

		internal bool ResetPlaylistEntries()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetPlaylistEntry(IntPtr self, int nID, int nPosition, string pchEntryText);

		internal bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetCurrentPlaylistEntry(IntPtr self, int nID);

		internal bool SetCurrentPlaylistEntry(int nID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _PlaylistDidChange(IntPtr self);

		internal bool PlaylistDidChange()
		{
			return false;
		}
	}
}
