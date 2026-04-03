using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[UsedByNativeCode]
	public class Renderer : Component
	{
		public Bounds bounds
		{
			[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
		}

		public Bounds localBounds
		{
			[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
			[NativeName("SetLocalAABB")]
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isVisible
		{
			[NativeName("IsVisibleInScene")]
			get
			{
				return false;
			}
		}

		public ShadowCastingMode shadowCastingMode
		{
			get
			{
				return default(ShadowCastingMode);
			}
			set
			{
			}
		}

		public bool receiveShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool forceRenderingOff
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool allowGPUDrivenRendering
		{
			set
			{
			}
		}

		internal bool smallMeshCulling
		{
			set
			{
			}
		}

		public MotionVectorGenerationMode motionVectorGenerationMode
		{
			get
			{
				return default(MotionVectorGenerationMode);
			}
			set
			{
			}
		}

		public LightProbeUsage lightProbeUsage
		{
			get
			{
				return default(LightProbeUsage);
			}
			set
			{
			}
		}

		public ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return default(ReflectionProbeUsage);
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int sortingGroupID => 0;

		internal int sortingGroupOrder => 0;

		public bool isPartOfStaticBatch
		{
			[NativeName("IsPartOfStaticBatch")]
			get
			{
				return false;
			}
		}

		public Matrix4x4 worldToLocalMatrix => default(Matrix4x4);

		public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

		public GameObject lightProbeProxyVolumeOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform probeAnchor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int lightmapIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int realtimeLightmapIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector4 lightmapScaleOffset
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Material[] materials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] sharedMaterials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[FreeFunction(Name = "RendererScripting::SetStaticLightmapST", HasExplicitThis = true)]
		private void SetStaticLightmapST(Vector4 st)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		private Material GetMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		private Material GetSharedMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		private void SetMaterial(Material m)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		private Material[] GetMaterialArray()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		private void CopyMaterialArray([Out] Material[] m)
		{
		}

		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		private void SetMaterialArray([NotNull] Material[] m, int length)
		{
		}

		private void SetMaterialArray(Material[] m)
		{
		}

		[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
		internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = true)]
		internal void Internal_GetPropertyBlock([NotNull] MaterialPropertyBlock dest)
		{
		}

		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		[NativeName("Renderer::GetMaskInteraction")]
		internal SpriteMaskInteraction Internal_GetSpriteMaskInteraction()
		{
			return default(SpriteMaskInteraction);
		}

		[NativeName("Renderer::SetMaskInteraction")]
		internal void Internal_SetSpriteMaskInteraction(SpriteMaskInteraction maskInteraction)
		{
		}

		[NativeName("GetLightmapIndexInt")]
		private int GetLightmapIndex(LightmapType lt)
		{
			return 0;
		}

		[NativeName("SetLightmapIndexInt")]
		private void SetLightmapIndex(int index, LightmapType lt)
		{
		}

		[NativeName("GetLightmapST")]
		private Vector4 GetLightmapST(LightmapType lt)
		{
			return default(Vector4);
		}

		[NativeName("SetLightmapST")]
		private void SetLightmapST(Vector4 st, LightmapType lt)
		{
		}

		private int GetMaterialCount()
		{
			return 0;
		}

		[NativeName("GetMaterialArray")]
		private Material[] GetSharedMaterialArray()
		{
			return null;
		}

		public void GetMaterials(List<Material> m)
		{
		}

		public void SetMaterials(List<Material> materials)
		{
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static void get_localBounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static void set_localBounds_Injected(IntPtr _unity_self, [In] ref Bounds value)
		{
		}

		private static void SetStaticLightmapST_Injected(IntPtr _unity_self, [In] ref Vector4 st)
		{
		}

		private static IntPtr GetMaterial_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m)
		{
		}

		private static Material[] GetMaterialArray_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static void CopyMaterialArray_Injected(IntPtr _unity_self, [Out] Material[] m)
		{
		}

		private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length)
		{
		}

		private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties)
		{
		}

		private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest)
		{
		}

		private static SpriteMaskInteraction Internal_GetSpriteMaskInteraction_Injected(IntPtr _unity_self)
		{
			return default(SpriteMaskInteraction);
		}

		private static void Internal_SetSpriteMaskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction maskInteraction)
		{
		}

		private static bool get_enabled_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_enabled_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_isVisible_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static ShadowCastingMode get_shadowCastingMode_Injected(IntPtr _unity_self)
		{
			return default(ShadowCastingMode);
		}

		private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value)
		{
		}

		private static bool get_receiveShadows_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_forceRenderingOff_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_forceRenderingOff_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_allowGPUDrivenRendering_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_smallMeshCulling_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static MotionVectorGenerationMode get_motionVectorGenerationMode_Injected(IntPtr _unity_self)
		{
			return default(MotionVectorGenerationMode);
		}

		private static void set_motionVectorGenerationMode_Injected(IntPtr _unity_self, MotionVectorGenerationMode value)
		{
		}

		private static LightProbeUsage get_lightProbeUsage_Injected(IntPtr _unity_self)
		{
			return default(LightProbeUsage);
		}

		private static void set_lightProbeUsage_Injected(IntPtr _unity_self, LightProbeUsage value)
		{
		}

		private static ReflectionProbeUsage get_reflectionProbeUsage_Injected(IntPtr _unity_self)
		{
			return default(ReflectionProbeUsage);
		}

		private static void set_reflectionProbeUsage_Injected(IntPtr _unity_self, ReflectionProbeUsage value)
		{
		}

		private static void get_sortingLayerName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static int get_sortingLayerID_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_sortingOrder_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_sortingOrder_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_sortingGroupID_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_sortingGroupOrder_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool get_isPartOfStaticBatch_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static IntPtr get_lightProbeProxyVolumeOverride_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_lightProbeProxyVolumeOverride_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static IntPtr get_probeAnchor_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_probeAnchor_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static int GetLightmapIndex_Injected(IntPtr _unity_self, LightmapType lt)
		{
			return 0;
		}

		private static void SetLightmapIndex_Injected(IntPtr _unity_self, int index, LightmapType lt)
		{
		}

		private static void GetLightmapST_Injected(IntPtr _unity_self, LightmapType lt, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static void SetLightmapST_Injected(IntPtr _unity_self, [In] ref Vector4 st, LightmapType lt)
		{
		}

		private static int GetMaterialCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self)
		{
			return null;
		}
	}
}
