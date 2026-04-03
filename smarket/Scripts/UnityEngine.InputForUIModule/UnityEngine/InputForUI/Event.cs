using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[StructLayout((LayoutKind)2)]
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct Event : IEventProperties
	{
		public enum Type
		{
			Invalid = 0,
			KeyEvent = 1,
			PointerEvent = 2,
			TextInputEvent = 3,
			IMECompositionEvent = 4,
			CommandEvent = 5,
			NavigationEvent = 6
		}

		private interface IMapFn<TOutputType>
		{
			TOutputType Map<TEventType>(ref TEventType ev);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct MapAsObject : IMapFn<IEventProperties>
		{
			public IEventProperties Map<TEventType>(ref TEventType ev)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct MapAsEventSource : IMapFn<EventSource>
		{
			public EventSource Map<TEventType>(ref TEventType ev)
			{
				return default(EventSource);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct MapAsEventModifiers : IMapFn<EventModifiers>
		{
			public EventModifiers Map<TEventType>(ref TEventType ev)
			{
				return default(EventModifiers);
			}
		}

		public static Type[] TypesWithState;

		[FieldOffset(0)]
		private Type _type;

		[FieldOffset(8)]
		private object _managedEvent;

		[FieldOffset(16)]
		private KeyEvent _keyEvent;

		[FieldOffset(16)]
		private PointerEvent _pointerEvent;

		[FieldOffset(16)]
		private TextInputEvent _textInputEvent;

		[FieldOffset(16)]
		private CommandEvent _commandEvent;

		[FieldOffset(16)]
		private NavigationEvent _navigationEvent;

		public Type type => default(Type);

		private IEventProperties asObject => null;

		public EventSource eventSource => default(EventSource);

		public EventModifiers eventModifiers => default(EventModifiers);

		public KeyEvent asKeyEvent => default(KeyEvent);

		public PointerEvent asPointerEvent => default(PointerEvent);

		public TextInputEvent asTextInputEvent => default(TextInputEvent);

		public IMECompositionEvent asIMECompositionEvent => default(IMECompositionEvent);

		public CommandEvent asCommandEvent => default(CommandEvent);

		public NavigationEvent asNavigationEvent => default(NavigationEvent);

		internal static int CompareType(Event a, Event b)
		{
			return 0;
		}

		private void Ensure(Type t)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static Event From(KeyEvent keyEvent)
		{
			return default(Event);
		}

		public static Event From(PointerEvent pointerEvent)
		{
			return default(Event);
		}

		public static Event From(TextInputEvent textInputEvent)
		{
			return default(Event);
		}

		public static Event From(IMECompositionEvent imeCompositionEvent)
		{
			return default(Event);
		}

		public static Event From(CommandEvent commandEvent)
		{
			return default(Event);
		}

		public static Event From(NavigationEvent navigationEvent)
		{
			return default(Event);
		}

		private TOutputType Map<TOutputType, TMapType>(TMapType fn)
		{
			return default(TOutputType);
		}

		private TOutputType Map<TOutputType, TMapType>() where TMapType : new()
		{
			return default(TOutputType);
		}
	}
}
