using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal class TextHandleTemporaryCache
	{
		internal LinkedList<TextCacheEntry> s_Cache;

		internal const int s_MinFramesInCache = 2;

		internal int currentFrame;

		private object syncRoot;

		public void ClearTemporaryCache()
		{
		}

		public void AddTextInfoToCache(TextHandle textHandle, int hashCode)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void RemoveFromCache(TextHandle handle)
		{
		}

		internal void ResetEntryState(TextHandle handle)
		{
		}

		private void RefreshCaching(TextHandle textHandle)
		{
		}

		private void RecycleTextInfoFromCache(TextHandle textHandle)
		{
		}

		public void UpdateCurrentFrame()
		{
		}
	}
}
