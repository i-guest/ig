using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		private static class Styles
		{
			public static readonly GUIContent none;
		}

		private static class Strings
		{
			public static readonly string cameraNeedsRendering;

			public static readonly string none;

			public static readonly string parameter;

			public static readonly string component;

			public static readonly string debugViewNotSupported;

			public static readonly string volumeInfo;

			public static readonly string gameObject;

			public static readonly string priority;

			public static readonly string resultValue;

			public static readonly string resultValueTooltip;

			public static readonly string globalDefaultValue;

			public static readonly string globalDefaultValueTooltip;

			public static readonly string qualityLevelValue;

			public static readonly string qualityLevelValueTooltip;

			public static readonly string global;

			public static readonly string local;

			public static readonly string volumeProfile;

			public static readonly string parameterNotCalculated;
		}

		internal static class WidgetFactory
		{
			private struct VolumeParameterChain
			{
				public DebugUI.Widget.NameAndTooltip nameAndTooltip;

				public VolumeProfile volumeProfile;

				public VolumeComponent volumeComponent;

				public Volume volume;
			}

			private static DebugUI.Value s_EmptyDebugUIValue;

			public static DebugUI.EnumField CreateComponentSelector(SettingsPanel panel, Action<DebugUI.Field<int>, int> refresh)
			{
				return null;
			}

			public static DebugUI.CameraSelector CreateCameraSelector(SettingsPanel panel, Action<DebugUI.Field<Object>, Object> refresh)
			{
				return null;
			}

			internal static DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param)
			{
				return null;
			}

			private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType)
			{
				return null;
			}

			private static List<VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data)
			{
				return null;
			}

			public static DebugUI.Table CreateVolumeTable(DebugDisplaySettingsVolume data)
			{
				return null;
			}

			private static void GenerateTableColumns(DebugUI.Table table, DebugDisplaySettingsVolume data, List<VolumeParameterChain> resolutionChain)
			{
			}

			private static void GenerateTableRows(DebugUI.Table table, List<VolumeParameterChain> resolutionChain)
			{
			}
		}

		[DisplayInfo(name = "Volume", order = 2147483647)]
		internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
		{
			private DebugUI.Table m_VolumeTable;

			public override DebugUI.Flags Flags => default(DebugUI.Flags);

			public override void Dispose()
			{
			}

			public SettingsPanel(DebugDisplaySettingsVolume data)
				: base((DebugDisplaySettingsVolume)default(_00210))
			{
			}

			private void OnVolumeInfluenceChanged(ObservableList<Volume> sender, ListChangedEventArgs<Volume> e)
			{
			}

			private void Refresh()
			{
			}
		}

		private int m_SelectedComponentIndex;

		private Camera m_SelectedCamera;

		private VolumeComponent m_VolumeInterpolatedResults;

		private bool m_StoreStackInterpolatedValues;

		private ObservableList<Volume> m_InfluenceVolumes;

		private List<(Volume volume, float weight)> m_VolumesWeights;

		internal int volumeComponentEnumIndex;

		private const string k_PanelTitle = "Volume";

		[Obsolete("This property has been obsoleted and will be removed in a future version. #from(6000.2)")]
		public IVolumeDebugSettings volumeDebugSettings { get; }

		public int selectedComponent
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Type selectedComponentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<(string, Type)> volumeComponentsPathAndType => null;

		public Camera selectedCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal VolumeComponent resultVolumeComponent => null;

		public bool AreAnySettingsActive => false;

		private void DestroyVolumeInterpolatedResults()
		{
		}

		private void OnSelectionChanged()
		{
		}

		private void ClearInterpolationData()
		{
		}

		private static bool AreVolumesChanged(ObservableList<Volume> influenceVolumes, List<(Volume volume, float weight)> volumesWeights)
		{
			return false;
		}

		private void OnBeginVolumeStackUpdate(VolumeStack stack, Camera camera)
		{
		}

		private void OnEndVolumeStackUpdate(VolumeStack stack, Camera camera)
		{
		}

		private void OnVolumeStackInterpolated(VolumeStack stack, Volume volume, float interpolationFactor)
		{
		}

		public float GetVolumeWeight(Volume volume)
		{
			return 0f;
		}

		public ObservableList<Volume> GetVolumesList()
		{
			return null;
		}

		void IDebugDisplaySettingsData.Reset()
		{
		}

		[Obsolete("This constructor has been obsoleted and will be removed in a future version. #from(6000.2)")]
		public DebugDisplaySettingsVolume(IVolumeDebugSettings volumeDebugSettings)
		{
		}

		public DebugDisplaySettingsVolume()
		{
		}

		internal static string ExtractResult(VolumeParameter param)
		{
			return null;
		}

		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
}
