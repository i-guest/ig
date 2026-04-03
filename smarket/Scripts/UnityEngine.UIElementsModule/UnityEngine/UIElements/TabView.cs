using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[UxmlElement(null, new Type[] { typeof(Tab) })]
	public class TabView : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<TabView, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private readonly UxmlBoolAttributeDescription m_Reorderable;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		[Serializable]
		private class ViewState : ISerializationCallbackReceiver
		{
			private bool m_HasPersistedData;

			[SerializeField]
			private List<string> m_TabOrder;

			[SerializeField]
			private string m_ActiveTabKey;

			internal void Save(TabView tabView)
			{
			}

			internal void Apply(TabView tabView)
			{
			}

			public void OnBeforeSerialize()
			{
			}

			public void OnAfterDeserialize()
			{
			}
		}

		private class TabViewContentContainer : VisualElement
		{
			internal override void OnChildAdded(VisualElement ve)
			{
			}

			internal override void OnChildRemoved(VisualElement ve)
			{
			}
		}

		internal static readonly BindingId reorderableProperty;

		public static readonly string ussClassName;

		public static readonly string headerContainerClassName;

		public static readonly string contentContainerUssClassName;

		public static readonly string reorderableUssClassName;

		public static readonly string verticalUssClassName;

		public static readonly string viewportUssClassName;

		public static readonly string nextButtonUssClassName;

		public static readonly string previousButtonUssClassName;

		private VisualElement m_HeaderContainer;

		private VisualElement m_ContentContainer;

		private List<Tab> m_Tabs;

		private List<VisualElement> m_TabHeaders;

		private Tab m_ActiveTab;

		private ViewState m_ViewState;

		private bool m_ApplyingViewState;

		private bool m_Reordering;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<Tab, Tab> activeTabChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<int, int> tabReordered;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<Tab, int> tabClosed;

		private bool m_Reorderable;

		public override VisualElement contentContainer => null;

		public VisualElement contentViewport { get; }

		internal VisualElement header => null;

		internal List<Tab> tabs => null;

		internal List<VisualElement> tabHeaders => null;

		internal RepeatButton nextButton { get; private set; }

		internal RepeatButton previousButton { get; private set; }

		internal float scrollableWidth => 0f;

		internal bool needsButtons => false;

		public Tab activeTab
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
		public bool reorderable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override void OnViewDataReady()
		{
		}

		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		private void OnGeometryChanged(GeometryChangedEvent evt)
		{
		}

		private void OnNextClicked()
		{
		}

		private void OnPreviousClicked()
		{
		}

		internal void UpdateButtons(Vector3 contentTransform)
		{
		}

		private void SaveViewState()
		{
		}

		private void UpdateIndexes()
		{
		}

		private void OnElementAdded(VisualElement ve)
		{
		}

		private void OnElementRemoved(VisualElement ve)
		{
		}

		private void OnTabSelected(Tab tab)
		{
		}

		private void OnTabClosed(Tab tab)
		{
		}

		public void ReorderTab(int from, int to)
		{
		}

		internal Tab FindTabByKey(string key)
		{
			return null;
		}
	}
}
