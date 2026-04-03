using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public class TwoPaneSplitView : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private UxmlIntAttributeDescription m_FixedPaneIndex;

			private UxmlIntAttributeDescription m_FixedPaneInitialDimension;

			private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId fixedPaneIndexProperty;

		internal static readonly BindingId fixedPaneInitialDimensionProperty;

		internal static readonly BindingId orientationProperty;

		private static readonly string s_UssClassName;

		private static readonly string s_ContentContainerClassName;

		private static readonly string s_HandleDragLineClassName;

		private static readonly string s_HandleDragLineVerticalClassName;

		private static readonly string s_HandleDragLineHorizontalClassName;

		private static readonly string s_HandleDragLineAnchorClassName;

		private static readonly string s_HandleDragLineAnchorVerticalClassName;

		private static readonly string s_HandleDragLineAnchorHorizontalClassName;

		private static readonly string s_VerticalClassName;

		private static readonly string s_HorizontalClassName;

		private VisualElement m_LeftPane;

		private VisualElement m_RightPane;

		private VisualElement m_FixedPane;

		private VisualElement m_FlexedPane;

		[SerializeField]
		[DontCreateProperty]
		private float m_FixedPaneDimension;

		private VisualElement m_DragLine;

		private VisualElement m_DragLineAnchor;

		private bool m_CollapseMode;

		private bool m_PendingCollapseToExecute;

		private int m_CollapsedChildIndex;

		private VisualElement m_Content;

		private TwoPaneSplitViewOrientation m_Orientation;

		private int m_FixedPaneIndex;

		private float m_FixedPaneInitialDimension;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal TwoPaneSplitViewResizer m_Resizer;

		public VisualElement fixedPane => null;

		public VisualElement flexedPane => null;

		internal VisualElement dragLine => null;

		[CreateProperty]
		public int fixedPaneIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float fixedPaneInitialDimension
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public TwoPaneSplitViewOrientation orientation
		{
			get
			{
				return default(TwoPaneSplitViewOrientation);
			}
			set
			{
			}
		}

		internal float fixedPaneDimension
		{
			get
			{
				return 0f;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			set
			{
			}
		}

		public override VisualElement contentContainer => null;

		private void SetupSplitView()
		{
		}

		public void CollapseChild(int index)
		{
		}

		internal virtual void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
		{
		}

		private void OnPostDisplaySetup(GeometryChangedEvent evt)
		{
		}

		private void AdjustPanesBasedOnAnchor()
		{
		}

		private void IdentifyLeftAndRightPane()
		{
		}

		private void PostDisplaySetup()
		{
		}

		private void OnSizeChange(GeometryChangedEvent evt)
		{
		}

		private void UpdateLayout(bool updateFixedPane, bool updateDragLine)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		private void SetDragLineOffset(float offset)
		{
		}

		private void SetFixedPaneDimension(float dimension)
		{
		}
	}
}
