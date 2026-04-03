using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class HelpBox : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Text;

			private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId textProperty;

		internal static readonly BindingId messageTypeProperty;

		public static readonly string ussClassName;

		public static readonly string labelUssClassName;

		public static readonly string iconUssClassName;

		public static readonly string iconInfoUssClassName;

		public static readonly string iconwarningUssClassName;

		public static readonly string iconErrorUssClassName;

		private HelpBoxMessageType m_HelpBoxMessageType;

		private VisualElement m_Icon;

		private string m_IconClass;

		private Label m_Label;

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

		[CreateProperty]
		public HelpBoxMessageType messageType
		{
			get
			{
				return default(HelpBoxMessageType);
			}
			set
			{
			}
		}

		public HelpBox()
		{
		}

		public HelpBox(string text, HelpBoxMessageType messageType)
		{
		}

		private string GetIconClass(HelpBoxMessageType messageType)
		{
			return null;
		}

		private void UpdateIcon(HelpBoxMessageType messageType)
		{
		}
	}
}
