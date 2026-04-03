using System.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	public class Message
	{
		internal static readonly ObjectPool<Message> Pool;

		public string Original { get; private set; }

		public List<MessageFragment> Fragments { get; private set; }

		public int Length => 0;

		public WritableMessageFragment CreateTextFragment(string original, int start, int end)
		{
			return null;
		}

		public WritableMessageFragment CreateTextFragment(string original)
		{
			return null;
		}

		public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original, int start, int end)
		{
			return null;
		}

		public ReadOnlyMessageFragment CreateReadonlyTextFragment(string original)
		{
			return null;
		}

		public void ReplaceFragment(MessageFragment original, MessageFragment replacement)
		{
		}

		public void ReleaseFragment(MessageFragment fragment)
		{
		}

		internal static Message CreateMessage(string text)
		{
			return null;
		}

		internal void Release()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
