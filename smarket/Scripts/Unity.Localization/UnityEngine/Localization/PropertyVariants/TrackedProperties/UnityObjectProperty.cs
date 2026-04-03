using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	[Serializable]
	public class UnityObjectProperty : ITrackedPropertyValue<Object>, ITrackedProperty, ISerializationCallbackReceiver
	{
		[Serializable]
		internal class LocaleIdentifierValuePair
		{
			public LocaleIdentifier localeIdentifier;

			public LazyLoadReference<Object> value;
		}

		[SerializeField]
		private string m_PropertyPath;

		[SerializeField]
		private string m_TypeString;

		[SerializeField]
		private List<LocaleIdentifierValuePair> m_VariantData;

		internal Dictionary<LocaleIdentifier, LocaleIdentifierValuePair> m_VariantLookup;

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

		public Type PropertyType { get; set; }

		public bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			return false;
		}

		public void RemoveVariant(LocaleIdentifier localeIdentifier)
		{
		}

		public bool GetValue(LocaleIdentifier localeIdentifier, out Object foundValue)
		{
			foundValue = null;
			return false;
		}

		public bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out Object foundValue)
		{
			foundValue = null;
			return false;
		}

		public void SetValue(LocaleIdentifier localeIdentifier, Object newValue)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
