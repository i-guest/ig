using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	public class FastAction
	{
		private LinkedList<Action> delegates;

		private Dictionary<Action, LinkedListNode<Action>> lookup;
	}
	public class FastAction<A>
	{
		private LinkedList<Action<A>> delegates;

		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;
	}
	public class FastAction<A, B>
	{
		private LinkedList<Action<A, B>> delegates;

		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;

		public void Call(A a, B b)
		{
		}
	}
	public class FastAction<A, B, C>
	{
		private LinkedList<Action<A, B, C>> delegates;

		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;
	}
}
