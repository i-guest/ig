using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal class TextHandlePermanentCache
	{
		internal LinkedList<TextCacheEntry> s_Cache;

		private object syncRoot;

		public void AddToCache(TextHandle textHandle)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		public void RemoveFromCache(TextHandle textHandle)
		{
		}

		private void ResetEntryState(TextHandle handle)
		{
		}
	}
}
