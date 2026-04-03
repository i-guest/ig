using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[NativeType(Header = "Runtime/2D/Common/ClipperOffsetWrapper.h")]
	internal struct ClipperOffset2D
	{
		public enum JoinType
		{
			jtSquare = 0,
			jtRound = 1,
			jtMiter = 2
		}

		public enum EndType
		{
			etClosedPolygon = 0,
			etClosedLine = 1,
			etOpenButt = 2,
			etOpenSquare = 3,
			etOpenRound = 4
		}

		[NativeType(Header = "Runtime/2D/Common/ClipperOffsetWrapper.h")]
		public struct PathArguments
		{
			public JoinType joinType;

			public EndType endType;
		}

		public struct Solution
		{
			public NativeArray<Vector2> points;

			public NativeArray<int> pathSizes;

			public void Dispose()
			{
			}
		}

		public static void Execute(ref Solution solution, NativeArray<Vector2> inPoints, NativeArray<int> inPathSizes, NativeArray<PathArguments> inPathArguments, Allocator inSolutionAllocator, double inDelta = 0.0, double inMiterLimit = 2.0, double inRoundPrecision = 0.25, double inArcTolerance = 0.0, double inIntScale = 65536.0, bool useRounding = false)
		{
		}

		[NativeMethod(Name = "ClipperOffset2D::Execute", IsFreeFunction = true, IsThreadSafe = true)]
		private static void Internal_Execute(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, double inDelta, double inMiterLimit, double inRoundPrecision, double inArcTolerance, double inIntScale, bool useRounding)
		{
			outClippedPoints = default(IntPtr);
			outClippedPointsCount = default(int);
			outClippedPathSizes = default(IntPtr);
			outClippedPathCount = default(int);
		}

		[NativeMethod(Name = "ClipperOffset2D::Execute_Cleanup", IsFreeFunction = true, IsThreadSafe = true)]
		private static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
		{
		}
	}
}
