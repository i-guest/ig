using System;
using System.Reflection;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	[DefaultMember("Item")]
	internal class EventCallbackList
	{
		public static readonly EventCallbackList EmptyList;

		private static readonly EventCallbackFunctorBase[] EmptyArray;

		private EventCallbackFunctorBase[] m_Array;

		private int m_Count;

		public Span<EventCallbackFunctorBase> Span => default(Span<EventCallbackFunctorBase>);

		public EventCallbackList()
		{
		}

		public EventCallbackList(EventCallbackList source)
		{
		}

		public EventCallbackFunctorBase Find(long eventTypeId, [NotNull] Delegate callback)
		{
			return null;
		}

		public bool Remove(long eventTypeId, [NotNull] Delegate callback, out EventCallbackFunctorBase removedFunctor)
		{
			removedFunctor = null;
			return false;
		}

		public void Add(EventCallbackFunctorBase item)
		{
		}

		public void AddRange(EventCallbackList list)
		{
		}

		public void Clear()
		{
		}
	}
}
