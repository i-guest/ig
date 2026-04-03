using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	internal sealed class DebugLogHandler : ILogHandler
	{
		[ThreadAndSerializationSafe]
		internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj)
		{
		}

		[ThreadAndSerializationSafe]
		internal static void Internal_LogException(Exception ex, Object obj)
		{
		}

		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
		}

		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
		}

		public void LogException(Exception exception, Object context)
		{
		}

		private static void Internal_Log_Injected(LogType level, LogOption options, ref ManagedSpanWrapper msg, IntPtr obj)
		{
		}

		private static void Internal_LogException_Injected(Exception ex, IntPtr obj)
		{
		}
	}
}
