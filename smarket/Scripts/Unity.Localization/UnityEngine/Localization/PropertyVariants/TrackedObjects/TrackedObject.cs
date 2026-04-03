using System;
using System.Collections.Generic;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	public abstract class TrackedObject : ISerializationCallbackReceiver
	{
		[Serializable]
		internal class TrackedPropertiesCollection
		{
			[SerializeReference]
			public List<ITrackedProperty> items;
		}

		[SerializeField]
		[HideInInspector]
		private Object m_Target;

		[SerializeField]
		private TrackedPropertiesCollection m_TrackedProperties;

		private readonly Dictionary<string, ITrackedProperty> m_PropertiesLookup;

		public Object Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<ITrackedProperty> TrackedProperties => null;

		public virtual bool CanTrackProperty(string propertyPath)
		{
			return false;
		}

		public T AddTrackedProperty<T>(string propertyPath) where T : new()
		{
			return default(T);
		}

		public virtual void AddTrackedProperty(ITrackedProperty trackedProperty)
		{
		}

		public virtual bool RemoveTrackedProperty(ITrackedProperty trackedProperty)
		{
			return false;
		}

		public T GetTrackedProperty<T>(string propertyPath, bool create = true) where T : new()
		{
			return default(T);
		}

		public virtual ITrackedProperty GetTrackedProperty(string propertyPath)
		{
			return null;
		}

		public virtual ITrackedProperty CreateCustomTrackedProperty(string propertyPath)
		{
			return null;
		}

		public abstract AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale);

		protected virtual void PostApplyTrackedProperties()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
