using System;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	[UxmlObject]
	public class SortColumnDescription : INotifyBindablePropertyChanged
	{
		[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : SortColumnDescription, new()
		{
		}

		[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescription>
		{
		}

		[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescription
		{
			private readonly UxmlStringAttributeDescription m_ColumnName;

			private readonly UxmlIntAttributeDescription m_ColumnIndex;

			private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;

			public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private static readonly BindingId columnNameProperty;

		private static readonly BindingId columnIndexProperty;

		private static readonly BindingId directionProperty;

		[SerializeField]
		private int m_ColumnIndex;

		[SerializeField]
		private string m_ColumnName;

		[SerializeField]
		private SortDirection m_SortDirection;

		[CreateProperty]
		public string columnName
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
		public int columnIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Column column { get; internal set; }

		[CreateProperty]
		public SortDirection direction
		{
			get
			{
				return default(SortDirection);
			}
			set
			{
			}
		}

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

		internal event Action<SortColumnDescription> changed
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

		public SortColumnDescription()
		{
		}

		public SortColumnDescription(int columnIndex, SortDirection direction)
		{
		}

		public SortColumnDescription(string columnName, SortDirection direction)
		{
		}

		private void NotifyPropertyChanged(in BindingId property)
		{
		}
	}
}
