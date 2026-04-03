using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class BaseBoolField : BaseField<bool>
	{
		internal static readonly BindingId textProperty;

		internal static readonly BindingId toggleOnLabelClickProperty;

		protected Label m_Label;

		protected internal readonly VisualElement m_CheckMark;

		internal readonly Clickable m_Clickable;

		private string m_OriginalText;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool acceptClicksIfDisabled
		{
			set
			{
			}
		}

		[CreateProperty]
		public bool toggleOnLabelClick { get; set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool toggleOnTextClick { get; set; }

		[CreateProperty]
		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BaseBoolField(string label)
			: base((string)null)
		{
		}

		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		protected virtual void InitLabel()
		{
		}

		public override void SetValueWithoutNotify(bool newValue)
		{
		}

		private void OnClickEvent(EventBase evt)
		{
		}

		private bool ShouldIgnoreClick(Vector3 position)
		{
			return false;
		}

		protected virtual void ToggleValue()
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}

		internal override void RegisterEditingCallbacks()
		{
		}

		internal override void UnregisterEditingCallbacks()
		{
		}
	}
}
