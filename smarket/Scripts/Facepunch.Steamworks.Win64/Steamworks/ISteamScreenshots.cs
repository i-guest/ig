using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamScreenshots : SteamInterface
	{
		public const string Version = "STEAMSCREENSHOTS_INTERFACE_VERSION003";

		internal ISteamScreenshots(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamScreenshots_v003();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern ScreenshotHandle _WriteScreenshot(IntPtr self, IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight);

		internal ScreenshotHandle WriteScreenshot(IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[PreserveSig]
		private static extern ScreenshotHandle _AddScreenshotToLibrary(IntPtr self, string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight);

		internal ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[PreserveSig]
		private static extern void _TriggerScreenshot(IntPtr self);

		internal void TriggerScreenshot()
		{
		}

		[PreserveSig]
		private static extern void _HookScreenshots(IntPtr self, bool bHook);

		internal void HookScreenshots(bool bHook)
		{
		}

		[PreserveSig]
		private static extern bool _SetLocation(IntPtr self, ScreenshotHandle hScreenshot, string pchLocation);

		internal bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _TagUser(IntPtr self, ScreenshotHandle hScreenshot, SteamId steamID);

		internal bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _TagPublishedFile(IntPtr self, ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID);

		internal bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsScreenshotsHooked(IntPtr self);

		internal bool IsScreenshotsHooked()
		{
			return false;
		}

		[PreserveSig]
		private static extern ScreenshotHandle _AddVRScreenshotToLibrary(IntPtr self, VRScreenshotType eType, string pchFilename, string pchVRFilename);

		internal ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
}
