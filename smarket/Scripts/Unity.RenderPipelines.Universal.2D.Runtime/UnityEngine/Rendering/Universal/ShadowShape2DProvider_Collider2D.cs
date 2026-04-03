using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ShadowShape2DProvider_Collider2D : ShadowShape2DProvider
	{
		private struct MinMaxBounds
		{
			public Vector3 min;

			public Vector3 max;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool Intersects(ref MinMaxBounds bounds)
			{
				return false;
			}

			public MinMaxBounds(ref Bounds bounds)
			{
				min = default(Vector3);
				max = default(Vector3);
			}
		}

		private const float k_InitialTrim = 0.05f;

		private List<Bounds> m_ShadowShapeBounds;

		private List<MinMaxBounds> m_ShadowShapeMinMaxBounds;

		private MinMaxBounds m_ShadowCombinedShapeMinMaxBounds;

		private Bounds m_LastWorldCullingBounds;

		private Matrix4x4 m_LastColliderSpace;

		private bool m_ShadowDirty;

		private uint m_ShadowStateHash;

		private PhysicsShapeGroup2D m_ShadowShapeGroup;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool CompareApproximately(ref Bounds a, ref Bounds b)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void TransformBounds2D(Matrix4x4 transform, ref Bounds bounds)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ClearShapes(ShadowShape2D persistantShapeObject)
		{
		}

		private void CalculateShadows(Collider2D collider, ShadowShape2D persistantShapeObject, Bounds worldCullingBounds)
		{
		}

		private void Initialize()
		{
		}

		public override bool IsShapeSource(Component sourceComponent)
		{
			return false;
		}

		public override void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShapeData)
		{
		}

		public override void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape)
		{
		}

		public override void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}
	}
}
