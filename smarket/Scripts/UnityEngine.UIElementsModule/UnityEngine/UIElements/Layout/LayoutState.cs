using System;

namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutState
	{
		public IntPtr measureFunctionCallback;

		public IntPtr baselineFunctionCallback;

		public IntPtr unusedExceptionPointer;

		public uint depth;

		public uint currentGenerationCount;

		public bool error;

		public static LayoutState Default => default(LayoutState);
	}
}
