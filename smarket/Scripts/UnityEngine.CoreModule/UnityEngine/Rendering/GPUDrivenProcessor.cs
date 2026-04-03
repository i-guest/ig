using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
	internal class GPUDrivenProcessor
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(GPUDrivenProcessor obj)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback;

		private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback;

		internal List<Mesh> scratchMeshes { get; private set; }

		internal List<Material> scratchMaterials { get; private set; }

		public bool enablePartialRendering
		{
			set
			{
			}
		}

		~GPUDrivenProcessor()
		{
		}

		public void Dispose()
		{
		}

		private void Destroy()
		{
		}

		private static IntPtr Internal_Create()
		{
			return (IntPtr)0;
		}

		private static void Internal_Destroy(IntPtr ptr)
		{
		}

		private void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<EntityId> renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly)
		{
		}

		public void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<EntityId> renderersID, GPUDrivenRendererDataCallback callback, bool materialUpdateOnly = false)
		{
		}

		public void DisableGPUDrivenRendering(ReadOnlySpan<EntityId> renderersID)
		{
		}

		private void DispatchLODGroupData(ReadOnlySpan<EntityId> lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param)
		{
		}

		public void DispatchLODGroupData(ReadOnlySpan<EntityId> lodGroupID, GPUDrivenLODGroupDataCallback callback)
		{
		}

		public void ClearMaterialFilters()
		{
		}

		[FreeFunction("GPUDrivenProcessor::ClassifyMaterials", IsThreadSafe = true)]
		private static int ClassifyMaterialsImpl(ReadOnlySpan<EntityId> materialIDs, Span<EntityId> unsupportedMaterialIDs, Span<EntityId> supportedMaterialIDs, Span<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
			return 0;
		}

		public static int ClassifyMaterials(NativeArray<EntityId> materialIDs, NativeArray<EntityId> unsupportedMaterialIDs, NativeArray<EntityId> supportedMaterialIDs, NativeArray<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
			return 0;
		}

		private static void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly)
		{
		}

		private static void DisableGPUDrivenRendering_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID)
		{
		}

		private static void DispatchLODGroupData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param)
		{
		}

		private static void set_enablePartialRendering_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void ClearMaterialFilters_Injected(IntPtr _unity_self)
		{
		}

		private static int ClassifyMaterialsImpl_Injected(ref ManagedSpanWrapper materialIDs, ref ManagedSpanWrapper unsupportedMaterialIDs, ref ManagedSpanWrapper supportedMaterialIDs, ref ManagedSpanWrapper supportedPackedMaterialDatas)
		{
			return 0;
		}
	}
}
