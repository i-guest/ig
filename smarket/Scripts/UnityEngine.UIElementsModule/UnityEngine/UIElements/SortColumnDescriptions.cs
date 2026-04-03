using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	[DefaultMember("Item")]
	[UxmlObject]
	public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
	{
		[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : SortColumnDescriptions, new()
		{
		}

		[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescriptions>
		{
		}

		[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescriptions
		{
			private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions;

			public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		[SerializeField]
		private readonly IList<SortColumnDescription> m_Descriptions;

		public int Count => 0;

		public bool IsReadOnly => false;

		internal event Action changed
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

		public IEnumerator<SortColumnDescription> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(SortColumnDescription item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(SortColumnDescription item)
		{
			return false;
		}

		public void CopyTo(SortColumnDescription[] array, int arrayIndex)
		{
		}

		public bool Remove(SortColumnDescription desc)
		{
			return false;
		}

		private void OnDescriptionChanged(SortColumnDescription desc)
		{
		}

		public void Insert(int index, SortColumnDescription desc)
		{
		}
	}
}
