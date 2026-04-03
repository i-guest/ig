using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	[Serializable]
	public class TrackedProperty<TPrimitive> : ITrackedPropertyValue<TPrimitive>, ITrackedProperty, IStringProperty, ISerializationCallbackReceiver, ITrackedPropertyRemoveVariant
	{
		[Serializable]
		internal class LocaleIdentifierValuePair
		{
			public LocaleIdentifier localeIdentifier;

			public TPrimitive value;
		}

		[SerializeField]
		private string m_PropertyPath;

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

		public bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			return false;
		}

		public void RemoveVariant(LocaleIdentifier localeIdentifier)
		{
		}

		public bool GetValue(LocaleIdentifier localeIdentifier, out TPrimitive foundValue)
		{
			foundValue = default(TPrimitive);
			return false;
		}

		public bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out TPrimitive foundValue)
		{
			foundValue = default(TPrimitive);
			return false;
		}

		public void SetValue(LocaleIdentifier localeIdentifier, TPrimitive value)
		{
		}

		public string GetValueAsString(LocaleIdentifier localeIdentifier)
		{
			return null;
		}

		public string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback)
		{
			return null;
		}

		public void SetValueFromString(LocaleIdentifier localeIdentifier, string stringValue)
		{
		}

		protected virtual string ConvertToString(TPrimitive value)
		{
			return null;
		}

		protected virtual TPrimitive ConvertFromString(string value)
		{
			return default(TPrimitive);
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
