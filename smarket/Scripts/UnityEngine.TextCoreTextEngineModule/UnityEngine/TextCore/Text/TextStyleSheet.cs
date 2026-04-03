using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	public class TextStyleSheet : ScriptableObject
	{
		[SerializeField]
		private List<TextStyle> m_StyleList;

		private Dictionary<int, TextStyle> m_StyleLookupDictionary;

		private object styleLookupLock;

		internal List<TextStyle> styles => null;

		private void Reset()
		{
		}

		public TextStyle GetStyle(int hashCode)
		{
			return null;
		}

		public TextStyle GetStyle(string name)
		{
			return null;
		}

		public void RefreshStyles()
		{
		}

		private void LoadStyleDictionaryInternal()
		{
		}
	}
}
