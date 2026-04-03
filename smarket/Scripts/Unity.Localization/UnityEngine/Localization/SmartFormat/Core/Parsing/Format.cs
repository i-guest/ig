using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	public class Format : FormatItem
	{
		internal class SplitList : IList<Format>, ICollection<Format>, IEnumerable<Format>, IEnumerable
		{
			private Format m_Format;

			private List<int> m_Splits;

			private List<Format> m_FormatCache;

			public Format this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int Count => 0;

			public bool IsReadOnly => false;

			public void Init(Format format, List<int> splits)
			{
			}

			public void CopyTo(Format[] array, int arrayIndex)
			{
			}

			public int IndexOf(Format item)
			{
				return 0;
			}

			public void Insert(int index, Format item)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Add(Format item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(Format item)
			{
				return false;
			}

			public bool Remove(Format item)
			{
				return false;
			}

			public IEnumerator<Format> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public Placeholder parent;

		private List<SplitList> m_Splits;

		private char splitCacheChar;

		private IList<Format> splitCache;

		public List<FormatItem> Items { get; }

		public bool HasNested { get; set; }

		public void ReleaseToPool()
		{
		}

		public Format Substring(int startIndex)
		{
			return null;
		}

		public Format Substring(int startIndex, int length)
		{
			return null;
		}

		public int IndexOf(char search)
		{
			return 0;
		}

		public int IndexOf(char search, int startIndex)
		{
			return 0;
		}

		private List<int> FindAll(char search)
		{
			return null;
		}

		private List<int> FindAll(char search, int maxCount)
		{
			return null;
		}

		public IList<Format> Split(char search)
		{
			return null;
		}

		public IList<Format> Split(char search, int maxCount)
		{
			return null;
		}

		public string GetLiteralText()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
