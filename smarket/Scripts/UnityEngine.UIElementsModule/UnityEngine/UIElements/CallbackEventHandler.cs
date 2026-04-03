using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class CallbackEventHandler : IEventHandler
	{
		internal bool isIMGUIContainer;

		internal EventCallbackRegistry m_CallbackRegistry;

		internal const string HandleEventBubbleUpName = "HandleEventBubbleUp";

		internal const string HandleEventTrickleDownName = "HandleEventTrickleDown";

		internal const string ExecuteDefaultActionName = "ExecuteDefaultAction";

		internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget";

		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void RegisterCallbackOnce<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		private void AddEventCategories<TEventType>(TrickleDown useTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void RegisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public void UnregisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		public abstract void SendEvent(EventBase e);

		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

		[EventInterest(EventInterestOptions.Inherit)]
		[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		[EventInterest(EventInterestOptions.Inherit)]
		protected virtual void HandleEventBubbleUp(EventBase evt)
		{
		}

		[EventInterest(EventInterestOptions.Inherit)]
		internal virtual void HandleEventBubbleUpDisabled(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void HandleEventBubbleUpInternal(EventBase evt)
		{
		}

		[EventInterest(EventInterestOptions.Inherit)]
		protected virtual void HandleEventTrickleDown(EventBase evt)
		{
		}

		[EventInterest(EventInterestOptions.Inherit)]
		internal virtual void HandleEventTrickleDownDisabled(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void HandleEventTrickleDownInternal(EventBase evt)
		{
		}

		[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
		[EventInterest(EventInterestOptions.Inherit)]
		protected virtual void ExecuteDefaultAction(EventBase evt)
		{
		}

		[Obsolete("Use HandleEventBubbleUpDisabled.")]
		[EventInterest(EventInterestOptions.Inherit)]
		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
		{
		}

		[EventInterest(EventInterestOptions.Inherit)]
		[Obsolete("Use HandleEventBubbleUpDisabled.")]
		internal virtual void ExecuteDefaultActionDisabled(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ExecuteDefaultActionInternal(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ExecuteDefaultActionDisabledInternal(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ExecuteDefaultActionAtTargetInternal(EventBase evt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ExecuteDefaultActionDisabledAtTargetInternal(EventBase evt)
		{
		}

		protected void NotifyPropertyChanged(in BindingId property)
		{
		}
	}
}
