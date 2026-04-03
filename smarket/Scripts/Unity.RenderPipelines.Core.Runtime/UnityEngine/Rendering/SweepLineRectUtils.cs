using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	public static class SweepLineRectUtils
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		private struct EventComparer : IComparer<Vector4>
		{
			public int Compare(Vector4 a, Vector4 b)
			{
				return 0;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct ActiveComparer : IComparer<Vector2>
		{
			public int Compare(Vector2 a, Vector2 b)
			{
				return 0;
			}
		}

		public static float CalculateRectUnionArea(List<Rect> rects)
		{
			return 0f;
		}

		private static float MergeLengthY(Vector2[] activeBuffer, int count)
		{
			return 0f;
		}

		private static float CalculateRectUnionArea(Vector4[] eventsBuffer, Vector2[] activeBuffer, int eventCount)
		{
			return 0f;
		}

		private static void InsertEvents(in Rect rect, Vector4[] eventsBuffer, ref int eventCount)
		{
		}
	}
}
