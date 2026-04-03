using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
	internal struct Clipper2D
	{
		public enum ClipType
		{
			ctIntersection = 0,
			ctUnion = 1,
			ctDifference = 2,
			ctXor = 3
		}

		public enum PolyType
		{
			ptSubject = 0,
			ptClip = 1
		}

		public enum PolyFillType
		{
			pftEvenOdd = 0,
			pftNonZero = 1,
			pftPositive = 2,
			pftNegative = 3
		}

		public enum InitOptions
		{
			ioDefault = 0,
			oReverseSolution = 1,
			ioStrictlySimple = 2,
			ioPreserveCollinear = 4
		}

		[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
		public struct PathArguments
		{
			public PolyType polyType;

			public bool closed;

			public PathArguments(PolyType inPolyType = PolyType.ptSubject, bool inClosed = false)
			{
				polyType = default(PolyType);
				closed = false;
			}
		}

		[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
		public struct ExecuteArguments
		{
			public InitOptions initOption;

			public ClipType clipType;

			public PolyFillType subjFillType;

			public PolyFillType clipFillType;

			public bool reverseSolution;

			public bool strictlySimple;

			public bool preserveColinear;

			public ExecuteArguments(InitOptions inInitOption = InitOptions.ioDefault, ClipType inClipType = ClipType.ctIntersection, PolyFillType inSubjFillType = PolyFillType.pftEvenOdd, PolyFillType inClipFillType = PolyFillType.pftEvenOdd, bool inReverseSolution = false, bool inStrictlySimple = false, bool inPreserveColinear = false)
			{
				initOption = default(InitOptions);
				clipType = default(ClipType);
				subjFillType = default(PolyFillType);
				clipFillType = default(PolyFillType);
				reverseSolution = false;
				strictlySimple = false;
				preserveColinear = false;
			}
		}

		public struct Solution : IDisposable
		{
			public NativeArray<Vector2> points;

			public NativeArray<int> pathSizes;

			public NativeArray<Rect> boundingRect;

			public void Dispose()
			{
			}
		}

		public static void Execute(ref Solution solution, NativeArray<Vector2> inPoints, NativeArray<int> inPathSizes, NativeArray<PathArguments> inPathArguments, ExecuteArguments inExecuteArguments, Allocator inSolutionAllocator, int inIntScale = 65536, bool useRounding = false)
		{
		}

		[NativeMethod(Name = "Clipper2D::Execute", IsFreeFunction = true, IsThreadSafe = true)]
		private static Rect Internal_Execute(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, ExecuteArguments inExecuteArguments, float inIntScale, bool useRounding)
		{
			outClippedPoints = default(IntPtr);
			outClippedPointsCount = default(int);
			outClippedPathSizes = default(IntPtr);
			outClippedPathCount = default(int);
			return default(Rect);
		}

		[NativeMethod(Name = "Clipper2D::Execute_Cleanup", IsFreeFunction = true, IsThreadSafe = true)]
		private static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
		{
		}

		private static void Internal_Execute_Injected(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, [In] ref ExecuteArguments inExecuteArguments, float inIntScale, bool useRounding, out Rect ret)
		{
			outClippedPoints = default(IntPtr);
			outClippedPointsCount = default(int);
			outClippedPathSizes = default(IntPtr);
			outClippedPathCount = default(int);
			ret = default(Rect);
		}
	}
}
