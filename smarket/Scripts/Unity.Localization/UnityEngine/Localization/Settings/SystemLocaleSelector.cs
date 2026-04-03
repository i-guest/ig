using System;
using System.Globalization;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class SystemLocaleSelector : IStartupLocaleSelector
	{
		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			return null;
		}

		private static Locale FindLocaleOrFallback(LocaleIdentifier localeIdentifier, ILocalesProvider availableLocales)
		{
			return null;
		}

		protected virtual CultureInfo GetSystemCulture()
		{
			return null;
		}

		protected virtual SystemLanguage GetApplicationSystemLanguage()
		{
			return default(SystemLanguage);
		}
	}
}
