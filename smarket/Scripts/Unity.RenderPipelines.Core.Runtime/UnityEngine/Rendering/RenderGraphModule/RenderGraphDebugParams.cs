using System.Collections.Generic;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class RenderGraphDebugParams : IDebugDisplaySettingsQuery
	{
		private static class Strings
		{
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;

			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtFree;

			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling;

			public static readonly DebugUI.Widget.NameAndTooltip DisablePassMerging;

			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode;

			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging;

			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation;

			public static readonly DebugUI.Widget.NameAndTooltip LogResources;
		}

		private DebugUI.Widget[] m_DebugItems;

		private DebugUI.Panel m_DebugPanel;

		public bool clearRenderTargetsAtCreation;

		public bool clearRenderTargetsAtRelease;

		public bool disablePassCulling;

		public bool disablePassMerging;

		public bool immediateMode;

		public bool logFrameInformation;

		public bool logResources;

		public bool enableLogging => false;

		public bool AreAnySettingsActive => false;

		public void ResetLogging()
		{
		}

		internal void Reset()
		{
		}

		internal List<DebugUI.Widget> GetWidgetList(string name)
		{
			return null;
		}

		private bool IsImmediateModeSupported()
		{
			return false;
		}

		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null)
		{
		}

		public void UnRegisterDebug(string name)
		{
		}
	}
}
