using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public readonly struct TreeViewItemData<T>
	{
		[CreateProperty]
		private readonly T m_Data;

		private readonly IList<TreeViewItemData<T>> m_Children;

		public int id { get; }

		public T data => default(T);

		public IEnumerable<TreeViewItemData<T>> children => null;
	}
}
