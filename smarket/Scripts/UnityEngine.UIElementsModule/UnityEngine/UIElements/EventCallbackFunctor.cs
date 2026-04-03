using System;

namespace UnityEngine.UIElements
{
	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		private EventCallback<TEventType> m_Callback;

		public static EventCallbackFunctor<TEventType> GetPooled(long eventTypeId, EventCallback<TEventType> callback, InvokePolicy invokePolicy = InvokePolicy.Default)
		{
			return null;
		}

		public override void Dispose()
		{
		}

		public override void Invoke(EventBase evt)
		{
		}

		public override void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown)
		{
		}

		public override bool IsEquivalentTo(long eventTypeId, Delegate callback)
		{
			return false;
		}
	}
	internal class EventCallbackFunctor<TEventType, TCallbackArgs> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		private EventCallback<TEventType, TCallbackArgs> m_Callback;

		internal TCallbackArgs userArgs { get; set; }

		public static EventCallbackFunctor<TEventType, TCallbackArgs> GetPooled(long eventTypeId, EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, InvokePolicy invokePolicy = InvokePolicy.Default)
		{
			return null;
		}

		public override void Dispose()
		{
		}

		public override void Invoke(EventBase evt)
		{
		}

		public override void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown)
		{
		}

		public override bool IsEquivalentTo(long eventTypeId, Delegate callback)
		{
			return false;
		}
	}
}
