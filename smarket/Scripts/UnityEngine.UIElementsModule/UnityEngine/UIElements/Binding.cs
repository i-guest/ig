using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine.UIElements
{
	[UxmlObject]
	public abstract class Binding
	{
		[Serializable]
		[ExcludeFromDocs]
		public abstract class UxmlSerializedData : UnityEngine.UIElements.UxmlSerializedData
		{
			[HideInInspector]
			[SerializeField]
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal string property;

			[SerializeField]
			[Tooltip("This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty.")]
			[HideInInspector]
			private BindingUpdateTrigger updateTrigger;

			[HideInInspector]
			[UxmlIgnore]
			[SerializeField]
			private UxmlAttributeFlags property_UxmlAttributeFlags;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags updateTrigger_UxmlAttributeFlags;

			public override void Deserialize(object obj)
			{
			}
		}

		private bool m_Dirty;

		private BindingUpdateTrigger m_UpdateTrigger;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Cproperty_003Ek__BackingField;

		internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty.";

		internal string property
		{
			[CompilerGenerated]
			set
			{
				_003Cproperty_003Ek__BackingField = value;
			}
		}

		public bool isDirty => false;

		[CreateProperty]
		public BindingUpdateTrigger updateTrigger
		{
			get
			{
				return default(BindingUpdateTrigger);
			}
			set
			{
			}
		}

		public static void SetGlobalLogLevel(BindingLogLevel logLevel)
		{
		}

		public static BindingLogLevel GetGlobalLogLevel()
		{
			return default(BindingLogLevel);
		}

		public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel)
		{
		}

		public static BindingLogLevel GetPanelLogLevel(IPanel panel)
		{
			return default(BindingLogLevel);
		}

		public static void ResetPanelLogLevel(IPanel panel)
		{
		}

		internal Binding()
		{
		}

		public void MarkDirty()
		{
		}

		internal void ClearDirty()
		{
		}

		protected internal virtual void OnActivated(in BindingActivationContext context)
		{
		}

		protected internal virtual void OnDeactivated(in BindingActivationContext context)
		{
		}

		protected internal virtual void OnDataSourceChanged(in DataSourceContextChanged context)
		{
		}
	}
}
