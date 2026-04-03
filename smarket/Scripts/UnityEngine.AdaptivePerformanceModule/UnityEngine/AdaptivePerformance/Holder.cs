using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.AdaptivePerformance
{
	public static class Holder
	{
		private static IAdaptivePerformance m_Instance;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static LifecycleEventHandler LifecycleEventHandler;

		public static IAdaptivePerformance Instance
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}
	}
}
