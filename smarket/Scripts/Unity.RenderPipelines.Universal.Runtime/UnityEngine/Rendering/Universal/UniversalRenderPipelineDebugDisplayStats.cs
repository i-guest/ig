using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	internal class UniversalRenderPipelineDebugDisplayStats : DebugDisplayStats<URPProfileId>
	{
		private DebugFrameTiming m_DebugFrameTiming;

		private List<URPProfileId> m_RecordedSamplers;

		public override void EnableProfilingRecorders()
		{
		}

		public override void DisableProfilingRecorders()
		{
		}

		public override void RegisterDebugUI(List<DebugUI.Widget> list)
		{
		}

		public override void Update()
		{
		}
	}
}
