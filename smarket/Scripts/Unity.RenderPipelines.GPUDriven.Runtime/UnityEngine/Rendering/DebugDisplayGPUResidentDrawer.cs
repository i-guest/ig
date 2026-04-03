namespace UnityEngine.Rendering
{
	public class DebugDisplayGPUResidentDrawer : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		private static class Strings
		{
			public const string drawerSettingsContainerName = "GPU Resident Drawer Settings";

			public static readonly DebugUI.Widget.NameAndTooltip displayBatcherStats;

			public const string occlusionCullingTitle = "Occlusion Culling";

			public static readonly DebugUI.Widget.NameAndTooltip occlusionTestOverlayEnable;

			public static readonly DebugUI.Widget.NameAndTooltip occlusionTestOverlayCountVisible;

			public static readonly DebugUI.Widget.NameAndTooltip overrideOcclusionTestToAlwaysPass;

			public static readonly DebugUI.Widget.NameAndTooltip occluderContextStats;

			public static readonly DebugUI.Widget.NameAndTooltip occluderDebugViewEnable;

			public static readonly DebugUI.Widget.NameAndTooltip occluderDebugViewIndex;

			public static readonly DebugUI.Widget.NameAndTooltip occluderDebugViewRangeMin;

			public static readonly DebugUI.Widget.NameAndTooltip occluderDebugViewRangeMax;
		}

		[DisplayInfo(name = "Rendering", order = 5)]
		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public override DebugUI.Flags Flags => default(DebugUI.Flags);

			public SettingsPanel(DebugDisplayGPUResidentDrawer data)
			{
			}

			private void AddInstanceCullingStatsWidget(DebugDisplayGPUResidentDrawer data)
			{
			}

			private void AddOcclusionContextStatsWidget(DebugDisplayGPUResidentDrawer data)
			{
			}
		}

		private const string k_FormatString = "{0}";

		private const float k_RefreshRate = 0.2f;

		private const int k_MaxViewCount = 32;

		private const int k_MaxOcclusionPassCount = 32;

		private const int k_MaxContextCount = 16;

		public bool occluderDebugViewEnable;

		internal bool occluderContextStats;

		internal Vector2 occluderDebugViewRange;

		internal int occluderDebugViewIndex;

		private bool displayBatcherStats
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool occlusionTestOverlayEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool occlusionTestOverlayCountVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool overrideOcclusionTestToAlwaysPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		internal bool GetOccluderViewInstanceID(out int viewInstanceID)
		{
			viewInstanceID = default(int);
			return false;
		}

		private static InstanceCullerViewStats GetInstanceCullerViewStats(int viewIndex)
		{
			return default(InstanceCullerViewStats);
		}

		private static InstanceOcclusionEventStats GetInstanceOcclusionEventStats(int passIndex)
		{
			return default(InstanceOcclusionEventStats);
		}

		private static DebugOccluderStats GetOccluderStats(int occluderIndex)
		{
			return default(DebugOccluderStats);
		}

		private static int GetOcclusionContextsCounts()
		{
			return 0;
		}

		private static int GetInstanceCullerViewCount()
		{
			return 0;
		}

		private static int GetInstanceOcclusionEventCount()
		{
			return 0;
		}

		private static DebugUI.Table.Row AddInstanceCullerViewDataRow(int viewIndex)
		{
			return null;
		}

		private static object OccluderVersionString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static object OcclusionTestString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static object VisibleInstancesString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static object CulledInstancesString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static object VisiblePrimitivesString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static object CulledPrimitivesString(in InstanceOcclusionEventStats stats)
		{
			return null;
		}

		private static DebugUI.Table.Row AddInstanceOcclusionPassDataRow(int eventIndex)
		{
			return null;
		}

		private static DebugUI.Table.Row AddOcclusionContextDataRow(int index)
		{
			return null;
		}

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		IDebugDisplaySettingsPanelDisposable IDebugDisplaySettingsData.CreatePanel()
		{
			return null;
		}
	}
}
