namespace UnityEngine.Rendering.Universal
{
	public class CullContextData : ContextItem
	{
		internal ScriptableRenderContext? m_RenderContext;

		public override void Reset()
		{
		}

		public void SetRenderContext(in ScriptableRenderContext renderContext)
		{
		}

		public CullingResults Cull(ref ScriptableCullingParameters parameters)
		{
			return default(CullingResults);
		}

		public void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos shadowCastersCullingInfos)
		{
		}
	}
}
