using System.Diagnostics;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	[DebuggerDisplay("Writable: {Text}")]
	public class WritableMessageFragment : MessageFragment
	{
		internal static readonly ObjectPool<WritableMessageFragment> Pool;

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
