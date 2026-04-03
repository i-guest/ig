using System;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class CommandLineLocaleSelector : IStartupLocaleSelector
	{
		[SerializeField]
		private string m_CommandLineArgument;

		public string CommandLineArgument
		{
			get
			{
				return null;
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
