using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class LocalesProvider : ILocalesProvider, IPreloadRequired, IReset, IDisposable
	{
		private readonly List<Locale> m_Locales;

		private AsyncOperationHandle m_LoadOperation;

		public List<Locale> Locales => null;

		public AsyncOperationHandle PreloadOperation => default(AsyncOperationHandle);

		public Locale GetLocale(LocaleIdentifier id)
		{
			return null;
		}

		public Locale GetLocale(string code)
		{
			return null;
		}

		public Locale GetLocale(SystemLanguage systemLanguage)
		{
			return null;
		}

		public void AddLocale(Locale locale)
		{
		}

		public bool RemoveLocale(Locale locale)
		{
			return false;
		}

		public Locale FindFallbackLocale(LocaleIdentifier localeIdentifier)
		{
			return null;
		}

		public void ResetState()
		{
		}

		~LocalesProvider()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
