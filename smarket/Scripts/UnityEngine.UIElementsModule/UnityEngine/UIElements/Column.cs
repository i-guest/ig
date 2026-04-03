using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[UxmlObject]
	public class Column : INotifyBindablePropertyChanged
	{
		[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : Column, new()
		{
		}

		[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory : UxmlObjectFactory<Column>
		{
		}

		[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Column
		{
			private UxmlStringAttributeDescription m_Name;

			private UxmlStringAttributeDescription m_Text;

			private UxmlBoolAttributeDescription m_Visible;

			private UxmlStringAttributeDescription m_Width;

			private UxmlStringAttributeDescription m_MinWidth;

			private UxmlStringAttributeDescription m_MaxWidth;

			private UxmlBoolAttributeDescription m_Stretch;

			private UxmlBoolAttributeDescription m_Sortable;

			private UxmlBoolAttributeDescription m_Optional;

			private UxmlBoolAttributeDescription m_Resizable;

			private UxmlStringAttributeDescription m_HeaderTemplateId;

			private UxmlStringAttributeDescription m_CellTemplateId;

			private UxmlStringAttributeDescription m_BindingPath;

			private static Length ParseLength(string str, Length defaultValue)
			{
				return default(Length);
			}

			public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private static readonly BindingId nameProperty;

		private static readonly BindingId titleProperty;

		private static readonly BindingId iconProperty;

		private static readonly BindingId visibleProperty;

		private static readonly BindingId widthProperty;

		private static readonly BindingId minWidthProperty;

		private static readonly BindingId maxWidthProperty;

		private static readonly BindingId sortableProperty;

		private static readonly BindingId stretchableProperty;

		private static readonly BindingId optionalProperty;

		private static readonly BindingId resizableProperty;

		private static readonly BindingId headerTemplateProperty;

		private static readonly BindingId cellTemplateProperty;

		private string m_Name;

		private string m_Title;

		private Background m_Icon;

		private bool m_Visible;

		private Length m_Width;

		private Length m_MinWidth;

		private Length m_MaxWidth;

		private float m_DesiredWidth;

		private bool m_Stretchable;

		private bool m_Sortable;

		private bool m_Optional;

		private bool m_Resizable;

		private VisualTreeAsset m_HeaderTemplate;

		private VisualTreeAsset m_CellTemplate;

		private Func<VisualElement> m_MakeHeader;

		private Action<VisualElement> m_BindHeader;

		private Action<VisualElement> m_UnbindHeader;

		private Action<VisualElement> m_DestroyHeader;

		private Func<VisualElement> m_MakeCell;

		private Action<VisualElement, int> m_BindCell;

		private Action<VisualElement, int> m_UnbindCellItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CbindingPath_003Ek__BackingField;

		[CreateProperty]
		public string name
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
		public string title
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
		public Background icon
		{
			get
			{
				return default(Background);
			}
			set
			{
			}
		}

		public Comparison<int> comparison { get; }

		internal int index => 0;

		internal int displayIndex => 0;

		internal int visibleIndex => 0;

		[CreateProperty]
		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Length width
		{
			get
			{
				return default(Length);
			}
			set
			{
			}
		}

		[CreateProperty]
		public Length minWidth
		{
			get
			{
				return default(Length);
			}
			set
			{
			}
		}

		[CreateProperty]
		public Length maxWidth
		{
			get
			{
				return default(Length);
			}
			set
			{
			}
		}

		internal float desiredWidth
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
		public bool sortable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool stretchable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool optional
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool resizable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string bindingPath
		{
			[CompilerGenerated]
			set
			{
				_003CbindingPath_003Ek__BackingField = value;
			}
		}

		[CreateProperty]
		public VisualTreeAsset headerTemplate
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
		public VisualTreeAsset cellTemplate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Func<VisualElement> makeHeader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<VisualElement> bindHeader => null;

		public Action<VisualElement> unbindHeader => null;

		public Action<VisualElement> destroyHeader => null;

		public Func<VisualElement> makeCell
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<VisualElement, int> bindCell => null;

		public Action<VisualElement, int> unbindCell => null;

		public Action<VisualElement> destroyCell { get; }

		public Columns collection { get; internal set; }

		public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
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

		internal event Action<Column, ColumnDataType> changed
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

		internal event Action<Column> resized
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

		private void NotifyChange(ColumnDataType type)
		{
		}

		private void NotifyPropertyChanged(in BindingId property)
		{
		}

		internal float GetWidth(float layoutWidth)
		{
			return 0f;
		}

		internal float GetMaxWidth(float layoutWidth)
		{
			return 0f;
		}

		internal float GetMinWidth(float layoutWidth)
		{
			return 0f;
		}
	}
}
