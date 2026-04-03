using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class Button : TextElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Button, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			private readonly UxmlImageAttributeDescription m_IconImage;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId iconImageProperty;

		public new static readonly string ussClassName;

		public static readonly string iconUssClassName;

		public static readonly string iconOnlyUssClassName;

		public static readonly string imageUSSClassName;

		private Clickable m_Clickable;

		private TextElement m_TextElement;

		private Image m_ImageElement;

		private Background m_IconImage;

		private string m_Text;

		private static readonly string NonEmptyString;

		public Clickable clickable
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
		public Background iconImage
		{
			get
			{
				return default(Background);
			}
			set
			{
			}
		}

		public override string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Button()
		{
		}

		public Button(Background iconImage, Action clickEvent = null)
		{
		}

		public Button(Action clickEvent)
		{
		}

		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		private void UpdateButtonHierarchy()
		{
		}

		private void ResetButtonHierarchy()
		{
		}
	}
}
