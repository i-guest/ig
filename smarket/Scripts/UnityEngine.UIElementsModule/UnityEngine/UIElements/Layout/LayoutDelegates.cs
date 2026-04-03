using System;
using AOT;
using Unity.Profiling;

namespace UnityEngine.UIElements.Layout
{
	internal static class LayoutDelegates
	{
		private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker;

		private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker;

		private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate;

		private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate;

		internal static readonly IntPtr s_InvokeMeasureFunction;

		internal static readonly IntPtr s_InvokeBaselineFunction;

		[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
		private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result)
		{
			result = default(LayoutSize);
		}

		[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
		private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height)
		{
			return 0f;
		}
	}
}
