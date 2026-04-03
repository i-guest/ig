using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[RequiredByNativeCode]
	public class BatchRendererGroup : IDisposable
	{
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext);

		public delegate void OnFinishedCulling(IntPtr customCullingResult);

		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(BatchRendererGroup batchRendererGroup)
			{
				return (IntPtr)0;
			}
		}

		private IntPtr m_GroupHandle;

		private OnPerformCulling m_PerformCulling;

		private OnFinishedCulling m_FinishedCulling;

		public static BatchBufferTarget BufferTarget => default(BatchBufferTarget);

		public BatchRendererGroup(BatchRendererGroupCreateInfo info)
		{
		}

		public void Dispose()
		{
		}

		private BatchID AddDrawCommandBatch(IntPtr values, int count, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize)
		{
			return default(BatchID);
		}

		public BatchID AddBatch(NativeArray<MetadataValue> batchMetadata, GraphicsBufferHandle buffer)
		{
			return default(BatchID);
		}

		private void RemoveDrawCommandBatch(BatchID batchID)
		{
		}

		public void RemoveBatch(BatchID batchID)
		{
		}

		internal void RegisterMaterials(ReadOnlySpan<EntityId> materialID, Span<BatchMaterialID> batchMaterialID)
		{
		}

		public void UnregisterMaterial(BatchMaterialID material)
		{
		}

		internal void RegisterMeshes(ReadOnlySpan<EntityId> meshID, Span<BatchMeshID> batchMeshID)
		{
		}

		public void UnregisterMesh(BatchMeshID mesh)
		{
		}

		private static BatchBufferTarget GetBufferTarget()
		{
			return default(BatchBufferTarget);
		}

		private unsafe static IntPtr Create([UnityMarshalAs(NativeType.ScriptingObjectPtr)] BatchRendererGroup group, void* userContext)
		{
			return (IntPtr)0;
		}

		private static void Destroy(IntPtr groupHandle)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult)
		{
		}

		[FreeFunction("BatchRendererGroup::OcclusionTestAABB", IsThreadSafe = true)]
		internal static bool OcclusionTestAABB(IntPtr occlusionBuffer, Bounds aabb)
		{
			return false;
		}

		private static void AddDrawCommandBatch_Injected(IntPtr _unity_self, IntPtr values, int count, [In] ref GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, out BatchID ret)
		{
			ret = default(BatchID);
		}

		private static void RemoveDrawCommandBatch_Injected(IntPtr _unity_self, [In] ref BatchID batchID)
		{
		}

		private static void RegisterMaterials_Injected(IntPtr _unity_self, ref ManagedSpanWrapper materialID, ref ManagedSpanWrapper batchMaterialID)
		{
		}

		private static void UnregisterMaterial_Injected(IntPtr _unity_self, [In] ref BatchMaterialID material)
		{
		}

		private static void RegisterMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper meshID, ref ManagedSpanWrapper batchMeshID)
		{
		}

		private static void UnregisterMesh_Injected(IntPtr _unity_self, [In] ref BatchMeshID mesh)
		{
		}

		private static bool OcclusionTestAABB_Injected(IntPtr occlusionBuffer, [In] ref Bounds aabb)
		{
			return false;
		}
	}
}
