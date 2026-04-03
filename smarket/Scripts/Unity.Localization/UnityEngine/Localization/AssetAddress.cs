namespace UnityEngine.Localization
{
	internal static class AssetAddress
	{
		private const string k_SubAssetEntryStartBracket = "[";

		private const string k_SubAssetEntryEndBracket = "]";

		public static bool IsSubAsset(string address)
		{
			return false;
		}

		public static string GetGuid(string address)
		{
			return null;
		}

		public static string GetSubAssetName(string address)
		{
			return null;
		}

		public static string FormatAddress(string guid, string subAssetName)
		{
			return null;
		}
	}
}
