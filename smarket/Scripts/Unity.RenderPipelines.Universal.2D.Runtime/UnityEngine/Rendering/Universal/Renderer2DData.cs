using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[ReloadGroup]
	[ExcludeFromPreset]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.Universal", "Unity.RenderPipelines.Universal.Runtime", null)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DRendererData-overview.html")]
	public class Renderer2DData : ScriptableRendererData
	{
		internal enum Renderer2DDefaultMaterialType
		{
			Lit = 0,
			Unlit = 1,
			Custom = 2
		}

		[SerializeField]
		private LayerMask m_LayerMask;

		[SerializeField]
		private TransparencySortMode m_TransparencySortMode;

		[SerializeField]
		private Vector3 m_TransparencySortAxis;

		[SerializeField]
		private float m_HDREmulationScale;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float m_LightRenderTextureScale;

		[SerializeField]
		[FormerlySerializedAs("m_LightOperations")]
		private Light2DBlendStyle[] m_LightBlendStyles;

		[SerializeField]
		private bool m_UseDepthStencilBuffer;

		[SerializeField]
		private bool m_UseCameraSortingLayersTexture;

		[SerializeField]
		private int m_CameraSortingLayersTextureBound;

		[SerializeField]
		private Downsampling m_CameraSortingLayerDownsamplingMethod;

		[SerializeField]
		private uint m_MaxLightRenderTextureCount;

		[SerializeField]
		private uint m_MaxShadowRenderTextureCount;

		[SerializeField]
		private PostProcessData m_PostProcessData;

		internal RTHandle normalsRenderTarget;

		internal RTHandle cameraSortingLayerRenderTarget;

		public float hdrEmulationScale => 0f;

		internal float lightRenderTextureScale => 0f;

		public Light2DBlendStyle[] lightBlendStyles => null;

		internal bool useDepthStencilBuffer => false;

		internal PostProcessData postProcessData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal TransparencySortMode transparencySortMode => default(TransparencySortMode);

		internal Vector3 transparencySortAxis => default(Vector3);

		internal uint lightRenderTextureMemoryBudget => 0u;

		internal uint shadowRenderTextureMemoryBudget => 0u;

		internal bool useCameraSortingLayerTexture => false;

		internal int cameraSortingLayerTextureBound => 0;

		internal Downsampling cameraSortingLayerDownsamplingMethod => default(Downsampling);

		internal LayerMask layerMask => default(LayerMask);

		internal Dictionary<uint, Material> lightMaterials { get; }

		internal Material spriteSelfShadowMaterial { get; set; }

		internal Material spriteUnshadowMaterial { get; set; }

		internal Material geometrySelfShadowMaterial { get; set; }

		internal Material geometryUnshadowMaterial { get; set; }

		internal Material projectedShadowMaterial { get; set; }

		internal Material projectedUnshadowMaterial { get; set; }

		internal ILight2DCullResult lightCullResult { get; set; }

		protected override ScriptableRenderer Create()
		{
			return null;
		}

		internal void Dispose()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
