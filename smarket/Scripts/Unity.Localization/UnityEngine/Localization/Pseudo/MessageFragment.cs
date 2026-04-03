using System.Text;

namespace UnityEngine.Localization.Pseudo
{
	public abstract class MessageFragment
	{
		protected string m_OriginalString;

		protected int m_StartIndex;

		protected int m_EndIndex;

		private string m_CachedToString;

		public int Length => 0;

		public Message Message { get; private set; }

		public char this[int index] => '\0';

		internal void Initialize(Message parent, string original, int start, int end)
		{
		}

		internal void Initialize(Message parent, string text)
		{
		}

		public WritableMessageFragment CreateTextFragment(int start, int end)
		{
			return null;
		}

		public ReadOnlyMessageFragment CreateReadonlyTextFragment(int start, int end)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal void BuildString(StringBuilder builder)
		{
		}
	}
}
