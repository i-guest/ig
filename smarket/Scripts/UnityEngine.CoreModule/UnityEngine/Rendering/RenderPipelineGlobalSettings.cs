using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public abstract class RenderPipelineGlobalSettings : ScriptableObject, ISerializationCallbackReceiver
	{
		protected virtual List<IRenderPipelineGraphicsSettings> settingsList => null;

		private Dictionary<Type, int> settingsMap { get; }

		private void RecreateSettingsMap()
		{
		}

		protected internal bool TryGet(Type type, out IRenderPipelineGraphicsSettings settings)
		{
			settings = null;
			return false;
		}

		protected internal bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(out TSettingsInterfaceType settings) where TSettingsInterfaceType : class, IRenderPipelineGraphicsSettings
		{
			settings = null;
			return false;
		}

		protected internal bool GetSettingsImplementingInterface<TSettingsInterfaceType>(out List<TSettingsInterfaceType> settings) where TSettingsInterfaceType : class, IRenderPipelineGraphicsSettings
		{
			settings = null;
			return false;
		}

		protected internal bool Contains(Type type)
		{
			return false;
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}
	}
}
