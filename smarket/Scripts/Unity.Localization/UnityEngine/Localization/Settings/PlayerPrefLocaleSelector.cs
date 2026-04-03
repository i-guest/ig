using System;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class PlayerPrefLocaleSelector : IStartupLocaleSelector, IInitialize
	{
		[SerializeField]
		private string m_PlayerPreferenceKey;

		public string PlayerPreferenceKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void PostInitialization(LocalizationSettings settings)
		{
		}

		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			return null;
		}
	}
}
