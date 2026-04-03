using System;

namespace UnityEngine.Rendering
{
	[Obsolete("VolumeComponentMenuForRenderPipelineAttribute is deprecated. Use VolumeComponentMenu with SupportedOnRenderPipeline instead. #from(2023.1)")]
	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
	{
		public Type[] pipelineTypes { get; }

		public VolumeComponentMenuForRenderPipeline(string menu, params Type[] pipelineTypes)
			: base(null)
		{
		}
	}
}
