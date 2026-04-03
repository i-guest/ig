using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.Universal.Internal;

[DisallowMultipleRendererFeature("On Tile Post Processing (Untethered XR)")]
public class OnTilePostProcessFeature : ScriptableRendererFeature
{
	[SerializeField]
	[HideInInspector]
	private PostProcessData m_PostProcessData;

	private Shader m_UberPostShader;

	private RenderPassEvent postProcessingEvent;

	private Material m_OnTilePostProcessMaterial;

	private ColorGradingLutPass m_ColorGradingLutPass;

	private OnTilePostProcessPass m_OnTilePostProcessPass;

	private bool TryLoadResources()
	{
		return false;
	}

	public override void Create()
	{
	}

	private bool IsRuntimePlatformUntetheredXR()
	{
		return false;
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
