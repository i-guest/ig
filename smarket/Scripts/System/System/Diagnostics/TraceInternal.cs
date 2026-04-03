namespace System.Diagnostics
{
	internal static class TraceInternal
	{
		private static string appName;

		private static TraceListenerCollection listeners;

		private static bool autoFlush;

		private static bool useGlobalLock;

		[ThreadStatic]
		private static int indentLevel;

		private static int indentSize;

		internal static readonly object critSec;

		public static TraceListenerCollection Listeners => null;

		public static bool AutoFlush => false;

		public static bool UseGlobalLock => false;

		public static int IndentLevel => 0;

		public static int IndentSize => 0;

		private static void InitializeSettings()
		{
		}

		public static void WriteLine(string message)
		{
		}
	}
}
