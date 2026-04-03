using System;

namespace UnityEngine.Rendering.Universal
{
	[Obsolete("This is not longer supported Please use DebugDisplaySettingsVolume. #from(6000.2)")]
	public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
	{
		public override VolumeStack selectedCameraVolumeStack => null;

		public override LayerMask selectedCameraLayerMask => default(LayerMask);

		public override Vector3 selectedCameraPosition => default(Vector3);

		[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(2023.2)")]
		public override Type targetRenderPipeline => null;
	}
}
