namespace UnityEngine.Rendering
{
	public interface IDefaultVolumeProfileSettings : IRenderPipelineGraphicsSettings
	{
		private bool UnityEngine_002ERendering_002EIRenderPipelineGraphicsSettings_002EisAvailableInPlayerBuild => false;

		VolumeProfile volumeProfile { get; set; }
	}
}
