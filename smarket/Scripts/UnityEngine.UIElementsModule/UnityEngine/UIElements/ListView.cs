using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class ListView : BaseListView
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseListView.UxmlTraits
		{
			private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId itemTemplateProperty;

		internal static readonly BindingId makeItemProperty;

		internal static readonly BindingId bindItemProperty;

		internal static readonly BindingId unbindItemProperty;

		internal static readonly BindingId destroyItemProperty;

		private Func<VisualElement> m_MakeItem;

		private Func<VisualElement> m_TemplateMakeItem;

		private VisualTreeAsset m_ItemTemplate;

		private Action<VisualElement, int> m_BindItem;

		private Action<VisualElement, int> m_UnbindItem;

		private Action<VisualElement> m_DestroyItem;

		[CreateProperty]
		public Func<VisualElement> makeItem
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
		public VisualTreeAsset itemTemplate
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
		public Action<VisualElement, int> bindItem
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
		public Action<VisualElement, int> unbindItem
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
		public Action<VisualElement> destroyItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private VisualElement TemplateMakeItem()
		{
			return null;
		}

		internal override bool HasValidDataAndBindings()
		{
			return false;
		}

		protected override CollectionViewController CreateViewController()
		{
			return null;
		}
	}
}
