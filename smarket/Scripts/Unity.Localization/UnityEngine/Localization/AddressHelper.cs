namespace UnityEngine.Localization
{
	internal class AddressHelper
	{
		private const char k_Separator = '_';

		private const string k_AssetLabelPrefix = "Locale-";

		public static string GetTableAddress(string tableName, LocaleIdentifier localeId)
		{
			return null;
		}

		public static string GetSharedTableAddress(string tableName)
		{
			return null;
		}

		public static string FormatAssetLabel(LocaleIdentifier localeIdentifier)
		{
			return null;
		}

		public static bool IsLocaleLabel(string label)
		{
			return false;
		}

		public static LocaleIdentifier LocaleLabelToId(string label)
		{
			return default(LocaleIdentifier);
		}

		public static bool TryGetLocaleLabelToId(string label, out LocaleIdentifier localeId)
		{
			localeId = default(LocaleIdentifier);
			return false;
		}
	}
}
