using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	internal class Light2DCullResult : ILight2DCullResult
	{
		private List<Light2D> m_VisibleLights;

		private HashSet<ShadowCasterGroup2D> m_VisibleShadows;

		public List<Light2D> visibleLights => null;

		public HashSet<ShadowCasterGroup2D> visibleShadows => null;

		public bool IsSceneLit()
		{
			return false;
		}

		public LightStats GetLightStatsByLayer(int layerID, ref LayerBatch layer)
		{
			return default(LightStats);
		}

		public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera)
		{
		}
	}
}
