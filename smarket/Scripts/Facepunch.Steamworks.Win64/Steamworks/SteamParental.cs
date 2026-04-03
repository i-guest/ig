using System;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	public class SteamParental : SteamSharedClass<SteamParental>
	{
		internal static ISteamParentalSettings Internal => null;

		public static bool IsParentalLockEnabled => false;

		public static bool IsParentalLockLocked => false;

		public static event Action OnSettingsChanged
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

		internal static void InstallEvents(bool server)
		{
		}

		public static bool IsAppBlocked(AppId app)
		{
			return false;
		}

		public static bool BIsAppInBlockList(AppId app)
		{
			return false;
		}

		public static bool IsFeatureBlocked(ParentalFeature feature)
		{
			return false;
		}

		public static bool BIsFeatureInBlockList(ParentalFeature feature)
		{
			return false;
		}
	}
}
