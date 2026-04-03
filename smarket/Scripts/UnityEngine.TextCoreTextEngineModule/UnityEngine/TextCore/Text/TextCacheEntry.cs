namespace UnityEngine.TextCore.Text
{
	internal struct TextCacheEntry
	{
		public TextHandle textHandle;

		public TextInfo textInfo;

		public float lastTimeInCache;

		public TextCacheEntry(TextHandle handle, TextInfo info, float time = 0f)
		{
			textHandle = null;
			textInfo = null;
			lastTimeInCache = 0f;
		}
	}
}
