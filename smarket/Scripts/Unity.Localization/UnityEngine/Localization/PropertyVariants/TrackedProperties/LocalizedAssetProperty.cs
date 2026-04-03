using System;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	[Serializable]
	public class LocalizedAssetProperty : ITrackedProperty
	{
		[SerializeReference]
		private LocalizedAssetBase m_Localized;

		[SerializeField]
		private string m_PropertyPath;

		public LocalizedAssetBase LocalizedObject
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
