using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ShadowShape2DProvider_SpriteRenderer : ShadowShape2DProvider
	{
		private const float k_InitialTrim = 0.05f;

		private ShadowShape2D m_PersistantShapeData;

		private SpriteDrawMode m_CurrentDrawMode;

		private Vector2 m_CurrentDrawModeSize;

		private void SetFullRectShapeData(SpriteRenderer spriteRenderer, ShadowShape2D shadowShape2D)
		{
		}

		private void SetPersistantShapeData(Sprite sprite, ShadowShape2D shadowShape2D, NativeSlice<Vector3> vertexSlice)
		{
		}

		private void TryToSetPersistantShapeData(SpriteRenderer spriteRenderer, ShadowShape2D persistantShadowShape, bool force)
		{
		}

		private void UpdatePersistantShapeData(SpriteRenderer spriteRenderer)
		{
		}

		public override int Priority()
		{
			return 0;
		}

		public override bool IsShapeSource(Component sourceComponent)
		{
			return false;
		}

		public override void OnPersistantDataCreated(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}

		public override void OnBeforeRender(Component sourceComponent, Bounds worldCullingBounds, ShadowShape2D persistantShadowShape)
		{
		}

		public override void Enabled(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}

		public override void Disabled(Component sourceComponent, ShadowShape2D persistantShadowShape)
		{
		}
	}
}
