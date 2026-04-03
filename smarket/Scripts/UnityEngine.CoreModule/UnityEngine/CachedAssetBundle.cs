using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct CachedAssetBundle
	{
		private string m_Name;

		private Hash128 m_Hash;

		public string name => null;

		public Hash128 hash => default(Hash128);

		public CachedAssetBundle(string name, Hash128 hash)
		{
			m_Name = null;
			m_Hash = default(Hash128);
		}
	}
}
