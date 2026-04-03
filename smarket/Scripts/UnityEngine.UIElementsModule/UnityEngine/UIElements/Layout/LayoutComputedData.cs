using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutComputedData
	{
		public unsafe fixed float Position[4];

		public unsafe fixed float Dimensions[2];

		public unsafe fixed float Margin[6];

		public unsafe fixed float Border[6];

		public unsafe fixed float Padding[6];

		public LayoutDirection Direction;

		public uint ComputedFlexBasisGeneration;

		public float ComputedFlexBasis;

		public bool HadOverflow;

		public uint GenerationCount;

		public LayoutDirection LastParentDirection;

		public float LastPointScaleFactor;

		public unsafe fixed float MeasuredDimensions[2];

		public static LayoutComputedData Default => default(LayoutComputedData);

		public unsafe float* MarginBuffer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		public unsafe float* BorderBuffer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		public unsafe float* PaddingBuffer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}
	}
}
