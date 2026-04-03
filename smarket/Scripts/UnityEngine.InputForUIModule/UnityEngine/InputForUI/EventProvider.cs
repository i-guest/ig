using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static class EventProvider
	{
		private struct Registration
		{
			public EventConsumer handler;

			public int priority;

			public int? playerId;

			public HashSet<Event.Type> _types;
		}

		private static IEventProviderImpl s_impl;

		private static EventSanitizer s_sanitizer;

		private static IEventProviderImpl s_implMockBackup;

		private static bool s_focusChangedRegistered;

		private static bool m_IsEnabled;

		private static bool m_IsInitialized;

		private static List<Registration> _registrations;

		public static void Subscribe(EventConsumer handler, int priority = 0, int? playerId = null, params Event.Type[] type)
		{
		}

		public static void Unsubscribe(EventConsumer handler)
		{
		}

		public static void SetEnabled(bool enable)
		{
		}

		internal static void Dispatch(in Event ev)
		{
		}

		private static void Bootstrap()
		{
		}

		private static void Initialize()
		{
		}

		private static void Shutdown()
		{
		}

		private static void OnFocusChanged(bool focus)
		{
		}

		[RequiredByNativeCode]
		internal static void NotifyUpdate()
		{
		}

		internal static void SetInputSystemProvider(IEventProviderImpl impl)
		{
		}
	}
}
