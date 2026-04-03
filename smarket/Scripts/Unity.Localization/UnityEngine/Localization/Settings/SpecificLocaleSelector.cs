using System;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class SpecificLocaleSelector : IStartupLocaleSelector
	{
		[SerializeField]
		private LocaleIdentifier m_LocaleId;

		public LocaleIdentifier LocaleId
		{
			get
			{
				return default(LocaleIdentifier);
			}
			set
			{
			}
		}

		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			return null;
		}
	}
}
