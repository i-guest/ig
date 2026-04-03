using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.LowLevelPhysics2D
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal static class PhysicsWorldRenderer
	{
		private struct DrawerGroup : IDisposable
		{
			private abstract class BaseDrawer : IDisposable
			{
				private bool m_Disposed;

				protected Mesh m_Mesh;

				protected GraphicsBuffer m_GraphicsBuffer;

				protected GraphicsBuffer.IndirectDrawIndexedArgs[] m_CommandData;

				protected ComputeBuffer m_ElementBuffer;

				protected Material m_ShaderMaterial;

				protected MaterialPropertyBlock m_ShaderMaterialPropertyBlock;

				protected readonly Bounds m_CullingBounds;

				protected readonly int m_ElementBufferShaderProperty;

				protected readonly int m_TransformPlaneShaderProperty;

				protected readonly int m_ThicknessShaderProperty;

				protected readonly int m_FillAlphaShaderProperty;

				protected Mesh GetMesh()
				{
					return null;
				}

				public void Dispose()
				{
				}

				public abstract void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity);
			}

			private sealed class PolygonGeometryDrawer : BaseDrawer
			{
				public override void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
				{
				}
			}

			private sealed class CircleGeometryDrawer : BaseDrawer
			{
				public override void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
				{
				}
			}

			private sealed class CapsuleGeometryDrawer : BaseDrawer
			{
				public override void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
				{
				}
			}

			private sealed class LineDrawer : BaseDrawer
			{
				public override void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
				{
				}
			}

			private sealed class PointDrawer : BaseDrawer
			{
				public override void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
				{
				}
			}

			private BaseDrawer[] m_Drawers;

			public readonly bool IsValid => false;

			public void Draw(CommandBuffer rendererCommandBuffer, ref PhysicsWorld.DrawResults drawResults, float thickness, float fillAlpha, PhysicsWorld.TransformPlane transformPlane, int drawCapacity)
			{
			}

			public void Dispose()
			{
			}
		}

		private static bool s_IsInitialized;

		private static bool s_UsingBIRP;

		private static CommandBuffer s_RendererCommandBuffer;

		private static DrawerGroup[] s_DrawerGroups;

		[RequiredByNativeCode]
		private static void InitializeRendering()
		{
		}

		[RequiredByNativeCode]
		private static void ShutdownRendering()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PhysicsAABB GetCameraViewAABB(Camera camera)
		{
			return default(PhysicsAABB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsCameraTypeValid(Camera camera)
		{
			return false;
		}

		private static void BIRP_RenderAllWorlds(Camera camera)
		{
		}

		private static void SRP_RenderAllWorlds(ScriptableRenderContext context, Camera camera)
		{
		}

		[RequiredByNativeCode]
		private static void SendDrawResultsToCommandBuffer(PhysicsWorld physicsWorld, PhysicsWorld.DrawResults drawResults, PhysicsWorld.TransformPlane transformPlane, float thickness, float fillAlpha, int drawCapacity)
		{
		}
	}
}
