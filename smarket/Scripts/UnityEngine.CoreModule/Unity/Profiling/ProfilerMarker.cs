using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
	[UsedByNativeCode]
	[IgnoredByDeepProfiler]
	public struct ProfilerMarker
	{
		[IgnoredByDeepProfiler]
		[UsedByNativeCode]
		public struct AutoScope : IDisposable
		{
			[NativeDisableUnsafePtrRestriction]
			internal readonly IntPtr m_Ptr;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal AutoScope(IntPtr markerPtr)
			{
				m_Ptr = (IntPtr)0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
			}
		}

		[NonSerialized]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr m_Ptr;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ProfilerMarker(string name)
		{
			m_Ptr = (IntPtr)0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ProfilerMarker(ProfilerCategory category, string name)
		{
			m_Ptr = (IntPtr)0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Pure]
		public AutoScope Auto()
		{
			return default(AutoScope);
		}
	}
}
