using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class RenderPipelineGraphicsSettingsContainer : ISerializationCallbackReceiver
	{
		[SerializeField]
		[HideInInspector]
		private RenderPipelineGraphicsSettingsCollection m_RuntimeSettings;

		public List<IRenderPipelineGraphicsSettings> settingsList => null;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
