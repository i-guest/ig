using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class RenderPipelineGraphicsSettingsCollection
	{
		[SerializeReference]
		private List<IRenderPipelineGraphicsSettings> m_List;

		public List<IRenderPipelineGraphicsSettings> settingsList => null;
	}
}
