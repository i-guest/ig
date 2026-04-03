using System.Diagnostics;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	[DebuggerDisplay("ReadOnly: {Text}")]
	public class ReadOnlyMessageFragment : MessageFragment
	{
		internal static readonly ObjectPool<ReadOnlyMessageFragment> Pool;

		public string Text => null;
	}
}
