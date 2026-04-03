using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class Tab : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Tab, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private readonly UxmlStringAttributeDescription m_Label;

			private readonly UxmlImageAttributeDescription m_IconImage;

			private readonly UxmlBoolAttributeDescription m_Closeable;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId labelProperty;

		internal static readonly BindingId iconImageProperty;

		internal static readonly BindingId closeableProperty;

		public static readonly string ussClassName;

		public static readonly string tabHeaderUssClassName;

		public static readonly string tabHeaderImageUssClassName;

		public static readonly string tabHeaderEmptyImageUssClassName;

		public static readonly string tabHeaderStandaloneImageUssClassName;

		public static readonly string tabHeaderLabelUssClassName;

		public static readonly string tabHeaderEmptyLabeUssClassName;

		public static readonly string tabHeaderUnderlineUssClassName;

		public static readonly string contentUssClassName;

		public static readonly string draggingUssClassName;

		public static readonly string reorderableUssClassName;

		public static readonly string reorderableItemHandleUssClassName;

		public static readonly string reorderableItemHandleBarUssClassName;

		public static readonly string closeableUssClassName;

		public static readonly string closeButtonUssClassName;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<bool> closing;

		private string m_Label;

		private Background m_IconImage;

		private bool m_Closeable;

		private VisualElement m_ContentContainer;

		private VisualElement m_DragHandle;

		private VisualElement m_CloseButton;

		private VisualElement m_TabHeader;

		private Image m_TabHeaderImage;

		private Label m_TabHeaderLabel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TabDragger _003Cdragger_003Ek__BackingField;

		public VisualElement tabHeader => null;

		internal int index { get; set; }

		[CreateProperty]
		public string label
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

		[CreateProperty]
		public bool closeable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override VisualElement contentContainer => null;

		public event Action<Tab> selected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Tab> closed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Tab()
		{
		}

		public Tab(string label, Background iconImage)
		{
		}

		private void UpdateTooltip(TooltipEvent evt)
		{
		}

		private void AddDragHandles()
		{
		}

		private void RemoveDragHandles()
		{
		}

		internal void EnableTabDragHandles(bool enable)
		{
		}

		private void AddCloseButton()
		{
		}

		private void RemoveCloseButton()
		{
		}

		internal void EnableTabCloseButton(bool enable)
		{
		}

		internal void SetActive()
		{
		}

		internal void SetInactive()
		{
		}

		private void OnTabClicked(PointerDownEvent _)
		{
		}

		private void OnCloseButtonClicked(PointerDownEvent evt)
		{
		}
	}
}
