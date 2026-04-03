using System;
using System.Diagnostics;
using Unity.Properties;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public abstract class LocalizedReference : CustomBinding, ISerializationCallbackReceiver
	{
		[Serializable]
		public new abstract class UxmlSerializedData : CustomBinding.UxmlSerializedData
		{
			[UxmlAttribute("table")]
			[SerializeField]
			private TableReference TableReferenceUXML;

			[UxmlAttribute("entry")]
			[SerializeField]
			private TableEntryReference TableEntryReferenceUXML;

			[UxmlAttribute("fallback")]
			[SerializeField]
			private FallbackBehavior FallbackStateUXML;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags TableReferenceUXML_UxmlAttributeFlags;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags TableEntryReferenceUXML_UxmlAttributeFlags;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags FallbackStateUXML_UxmlAttributeFlags;

			[RegisterUxmlCache]
			[Conditional("UNITY_EDITOR")]
			public static void Register()
			{
			}

			public override void Deserialize(object obj)
			{
			}
		}

		[SerializeField]
		private TableReference m_TableReference;

		[SerializeField]
		private TableEntryReference m_TableEntryReference;

		[SerializeField]
		private FallbackBehavior m_FallbackState;

		[SerializeField]
		private bool m_WaitForCompletion;

		internal Locale m_LocaleOverride;

		private int m_ActivatedCount;

		public TableReference TableReference
		{
			get
			{
				return default(TableReference);
			}
			set
			{
			}
		}

		public TableEntryReference TableEntryReference
		{
			get
			{
				return default(TableEntryReference);
			}
			set
			{
			}
		}

		public FallbackBehavior FallbackState
		{
			get
			{
				return default(FallbackBehavior);
			}
			set
			{
			}
		}

		public Locale LocaleOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool WaitForCompletion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal abstract bool ForceSynchronous { get; }

		public bool IsEmpty => false;

		[UxmlAttribute("table")]
		internal TableReference TableReferenceUXML
		{
			get
			{
				return default(TableReference);
			}
			set
			{
			}
		}

		[UxmlAttribute("entry")]
		internal TableEntryReference TableEntryReferenceUXML
		{
			get
			{
				return default(TableEntryReference);
			}
			set
			{
			}
		}

		[UxmlAttribute("fallback")]
		internal FallbackBehavior FallbackStateUXML
		{
			get
			{
				return default(FallbackBehavior);
			}
			set
			{
			}
		}

		public void SetReference(TableReference table, TableEntryReference entry)
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected internal abstract void ForceUpdate();

		protected abstract void Reset();

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		public LocalizedReference()
		{
		}

		protected override void OnActivated(in BindingActivationContext context)
		{
		}

		protected override void OnDeactivated(in BindingActivationContext context)
		{
		}

		protected abstract void Initialize();

		protected abstract void Cleanup();

		internal BindingResult CreateErrorResult(in BindingContext context, VisitReturnCode errorCode, Type sourceType)
		{
			return default(BindingResult);
		}
	}
}
