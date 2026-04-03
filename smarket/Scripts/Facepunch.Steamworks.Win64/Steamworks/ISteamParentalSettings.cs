using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamParentalSettings : SteamInterface
	{
		public const string Version = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";

		internal ISteamParentalSettings(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamParentalSettings_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _BIsParentalLockEnabled(IntPtr self);

		internal bool BIsParentalLockEnabled()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsParentalLockLocked(IntPtr self);

		internal bool BIsParentalLockLocked()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsAppBlocked(IntPtr self, AppId nAppID);

		internal bool BIsAppBlocked(AppId nAppID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsAppInBlockList(IntPtr self, AppId nAppID);

		internal bool BIsAppInBlockList(AppId nAppID)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsFeatureBlocked(IntPtr self, ParentalFeature eFeature);

		internal bool BIsFeatureBlocked(ParentalFeature eFeature)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BIsFeatureInBlockList(IntPtr self, ParentalFeature eFeature);

		internal bool BIsFeatureInBlockList(ParentalFeature eFeature)
		{
			return false;
		}
	}
}
