using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GeometryUtilityScripting", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class GeometryUtility
	{
		public static Plane[] CalculateFrustumPlanes(Camera camera)
		{
			return null;
		}

		public static Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			return null;
		}

		public static void CalculateFrustumPlanes(Camera camera, Span<Plane> planes)
		{
		}

		public static void CalculateFrustumPlanes(Camera camera, Plane[] planes)
		{
		}

		public static void CalculateFrustumPlanes(in Matrix4x4 worldToProjectionMatrix, Span<Plane> planes)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes)
		{
		}

		[NativeName("TestPlanesAABB")]
		private static bool Internal_TestPlanesAABB(ReadOnlySpan<Plane> planes, in Bounds bounds)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds)
		{
			return false;
		}

		[NativeName("ExtractPlanes")]
		private static void Internal_ExtractPlanes(Span<Plane> planes, in Matrix4x4 worldToProjectionMatrix)
		{
		}

		private static bool Internal_TestPlanesAABB_Injected(ref ManagedSpanWrapper planes, in Bounds bounds)
		{
			return false;
		}

		private static void Internal_ExtractPlanes_Injected(ref ManagedSpanWrapper planes, in Matrix4x4 worldToProjectionMatrix)
		{
		}
	}
}
