using System;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class FallbackLocale : IMetadata
	{
		[SerializeField]
		private Locale m_Locale;

		public Locale Locale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FallbackLocale()
		{
		}

		public FallbackLocale(Locale fallback)
		{
		}

		internal bool IsCyclic(Locale locale)
		{
			return false;
		}
	}
}
