using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamMusic : SteamInterface
	{
		public const string Version = "STEAMMUSIC_INTERFACE_VERSION001";

		internal ISteamMusic(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamMusic_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _BIsEnabled(IntPtr self);

		internal bool BIsEnabled()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsPlaying(IntPtr self);

		internal bool BIsPlaying()
		{
			return false;
		}

		[PreserveSig]
		private static extern MusicStatus _GetPlaybackStatus(IntPtr self);

		internal MusicStatus GetPlaybackStatus()
		{
			return default(MusicStatus);
		}

		[PreserveSig]
		private static extern void _Play(IntPtr self);

		internal void Play()
		{
		}

		[PreserveSig]
		private static extern void _Pause(IntPtr self);

		internal void Pause()
		{
		}

		[PreserveSig]
		private static extern void _PlayPrevious(IntPtr self);

		internal void PlayPrevious()
		{
		}

		[PreserveSig]
		private static extern void _PlayNext(IntPtr self);

		internal void PlayNext()
		{
		}

		[PreserveSig]
		private static extern void _SetVolume(IntPtr self, float flVolume);

		internal void SetVolume(float flVolume)
		{
		}

		[PreserveSig]
		private static extern float _GetVolume(IntPtr self);

		internal float GetVolume()
		{
			return 0f;
		}
	}
}
