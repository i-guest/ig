using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[RequiredByNativeCode]
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	public static class AnalyticsSessionInfo
	{
		public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);

		public delegate void IdentityTokenChanged(string token);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static SessionStateChanged sessionStateChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static IdentityTokenChanged identityTokenChanged;

		[RequiredByNativeCode]
		internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
		}

		[RequiredByNativeCode]
		internal static void CallIdentityTokenChanged(string token)
		{
		}
	}
}
