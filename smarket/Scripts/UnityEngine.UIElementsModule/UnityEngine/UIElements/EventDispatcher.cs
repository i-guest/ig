using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	public sealed class EventDispatcher
	{
		private struct EventRecord
		{
			public EventBase m_Event;

			public BaseVisualElementPanel m_Panel;
		}

		private struct DispatchContext
		{
			public uint m_GateCount;

			public Queue<EventRecord> m_Queue;
		}

		internal ClickDetector m_ClickDetector;

		private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool;

		private Queue<EventRecord> m_Queue;

		private uint m_GateCount;

		private uint m_GateDepth;

		internal const int k_MaxGateDepth = 500;

		internal const int k_NumberOfEventsWithStackInfo = 10;

		internal const int k_NumberOfEventsWithEventInfo = 100;

		private int m_DispatchStackFrame;

		private EventBase m_CurrentEvent;

		private Stack<DispatchContext> m_DispatchContexts;

		private bool m_Immediate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CprocessingEvents_003Ek__BackingField;

		internal PointerDispatchState pointerState { get; }

		private bool dispatchImmediately => false;

		private bool processingEvents
		{
			[CompilerGenerated]
			set
			{
				_003CprocessingEvents_003Ek__BackingField = value;
			}
		}

		internal static EventDispatcher CreateDefault()
		{
			return null;
		}

		[Obsolete("Please use EventDispatcher.CreateDefault().")]
		internal EventDispatcher()
		{
		}

		internal void Dispatch(EventBase evt, [NotNull] BaseVisualElementPanel panel, DispatchMode dispatchMode)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HandleRecursiveState(EventBase evt)
		{
			return false;
		}

		internal void CloseGate()
		{
		}

		internal void OpenGate()
		{
		}

		private void ProcessEventQueue()
		{
		}

		private void ProcessEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel)
		{
		}
	}
}
