using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	internal class EventCallbackRegistry
	{
		internal struct DynamicCallbackList
		{
			private TrickleDown m_UseTrickleDown;

			[NotNull]
			private EventCallbackList m_Callbacks;

			[CanBeNull]
			private EventCallbackList m_TemporaryCallbacks;

			[CanBeNull]
			private List<EventCallbackFunctorBase> m_UnregisteredCallbacksDuringInvoke;

			private int m_IsInvoking;

			public static DynamicCallbackList Create(TrickleDown useTrickleDown)
			{
				return default(DynamicCallbackList);
			}

			[NotNull]
			public EventCallbackList GetCallbackListForWriting()
			{
				return null;
			}

			[NotNull]
			public readonly EventCallbackList GetCallbackListForReading()
			{
				return null;
			}

			public bool UnregisterCallback(long eventTypeId, [NotNull] Delegate callback)
			{
				return false;
			}

			public void Invoke(EventBase evt, BaseVisualElementPanel panel, VisualElement target)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void BeginInvoke()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void EndInvoke()
			{
			}
		}

		private static readonly EventCallbackListPool s_ListPool;

		internal DynamicCallbackList m_TrickleDownCallbacks;

		internal DynamicCallbackList m_BubbleUpCallbacks;

		private static EventCallbackList GetCallbackList(EventCallbackList initializer = null)
		{
			return null;
		}

		private static void ReleaseCallbackList(EventCallbackList toRelease)
		{
		}

		private ref DynamicCallbackList GetDynamicCallbackList(TrickleDown useTrickleDown)
		{
			throw null;
		}

		public void RegisterCallback<TEventType>([NotNull] EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void RegisterCallback<TEventType, TCallbackArgs>([NotNull] EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
		{
		}

		public bool UnregisterCallback<TEventType>([NotNull] EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			return false;
		}

		public bool UnregisterCallback<TEventType, TCallbackArgs>([NotNull] EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			return false;
		}
	}
}
