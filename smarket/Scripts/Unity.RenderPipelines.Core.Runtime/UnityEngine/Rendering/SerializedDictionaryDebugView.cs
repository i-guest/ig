using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	internal sealed class SerializedDictionaryDebugView<K, V>
	{
		private IDictionary<K, V> dict;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public KeyValuePair<K, V>[] Items => null;

		public SerializedDictionaryDebugView(IDictionary<K, V> dictionary)
		{
		}
	}
}
