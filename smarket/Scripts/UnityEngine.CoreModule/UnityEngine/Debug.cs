using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	[NativeHeader("Runtime/Diagnostics/Validation.h")]
	public class Debug
	{
		internal static readonly ILogger s_DefaultLogger;

		internal static ILogger s_Logger;

		public static ILogger unityLogger => null;

		public static bool isDebugBuild => false;

		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
		}

		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
		}

		[FreeFunction("DebugDrawLine", IsThreadSafe = true)]
		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}

		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
		}

		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
		}

		public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}

		[FreeFunction("PauseEditor")]
		public static void Break()
		{
		}

		[ThreadSafe]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			return 0;
		}

		public static void Log(object message)
		{
		}

		public static void Log(object message, Object context)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogFormat(Object context, string format, params object[] args)
		{
		}

		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
		}

		public static void LogError(object message)
		{
		}

		public static void LogError(object message, Object context)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
		}

		public static void LogException(Exception exception)
		{
		}

		public static void LogException(Exception exception, Object context)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarning(object message, Object context)
		{
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		[RequiredByNativeCode]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static bool IsLoggingEnabled()
		{
			return false;
		}

		private static void DrawLine_Injected([In] ref Vector3 start, [In] ref Vector3 end, [In][DefaultValue("Color.white")] ref Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}

		private unsafe static int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder)
		{
			return 0;
		}
	}
}
