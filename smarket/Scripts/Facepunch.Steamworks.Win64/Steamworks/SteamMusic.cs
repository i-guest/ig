using System;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	public class SteamMusic : SteamClientClass<SteamMusic>
	{
		internal static ISteamMusic Internal => null;

		public static bool IsEnabled => false;

		public static bool IsPlaying => false;

		public static MusicStatus Status => default(MusicStatus);

		public static float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static event Action OnPlaybackChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<float> OnVolumeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal static void InstallEvents()
		{
		}

		public static void Play()
		{
		}

		public static void Pause()
		{
		}

		public static void PlayPrevious()
		{
		}

		public static void PlayNext()
		{
		}
	}
}
