using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal static class NativeListExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ReadOnlySpan<T> MakeReadOnlySpan<T>(this ref NativeList<T> list, int first, int numElements) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndex<T>(this ref NativeList<T> list) where T : struct
		{
			return 0;
		}
	}
}
