using System;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	[Serializable]
	public class LocalizedStringProperty : ITrackedProperty
	{
		[SerializeField]
		private LocalizedString m_Localized;

		[SerializeField]
		private string m_PropertyPath;

		public LocalizedString LocalizedString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PropertyPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			return false;
		}
	}
}
