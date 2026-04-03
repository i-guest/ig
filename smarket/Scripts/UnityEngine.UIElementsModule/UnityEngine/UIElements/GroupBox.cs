using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class GroupBox : BindableElement, IGroupBox
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Text;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId textProperty;

		public static readonly string ussClassName;

		public static readonly string labelUssClassName;

		private Label m_TitleLabel;

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

		public GroupBox()
		{
		}

		public GroupBox(string text)
		{
		}

		void IGroupBox.OnOptionAdded(IGroupBoxOption option)
		{
		}

		void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
		{
		}
	}
}
