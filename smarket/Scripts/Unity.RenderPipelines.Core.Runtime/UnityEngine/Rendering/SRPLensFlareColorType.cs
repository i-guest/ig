using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\PostProcessing\\LensFlareDataSRP.cs")]
	public enum SRPLensFlareColorType
	{
		Constant = 0,
		RadialGradient = 1,
		AngularGradient = 2
	}
}
