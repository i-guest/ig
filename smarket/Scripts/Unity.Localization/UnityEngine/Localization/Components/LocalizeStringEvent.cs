using System.Collections.Generic;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	[AddComponentMenu("Localization/Localize String Event")]
	public class LocalizeStringEvent : LocalizedMonoBehaviour
	{
		[SerializeField]
		private LocalizedString m_StringReference;

		[SerializeField]
		private List<Object> m_FormatArguments;

		[SerializeField]
		private UnityEventString m_UpdateString;

		private LocalizedString.ChangeHandler m_ChangeHandler;

		public LocalizedString StringReference
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnityEventString OnUpdateString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void RefreshString()
		{
		}

		public void SetTable(string tableReference)
		{
		}

		public void SetEntry(string entryName)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void UpdateString(string value)
		{
		}

		private void OnValidate()
		{
		}

		internal virtual void RegisterChangeHandler()
		{
		}

		internal virtual void ClearChangeHandler()
		{
		}
	}
}
