using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Unity.Profiling;

namespace UnityEngine.Rendering
{
	public sealed class VolumeManager
	{
		private static readonly ProfilerMarker k_ProfilerMarkerUpdate;

		private static readonly ProfilerMarker k_ProfilerMarkerReplaceData;

		private static readonly ProfilerMarker k_ProfilerMarkerEvaluateVolumeDefaultState;

		private static readonly Lazy<VolumeManager> s_Instance;

		private static readonly Dictionary<Type, List<(string, Type)>> s_SupportedVolumeComponentsForRenderPipeline;

		private Type[] m_BaseComponentTypeArray;

		private readonly VolumeCollection m_VolumeCollection;

		private VolumeComponent[] m_ComponentsDefaultState;

		internal VolumeParameter[] m_ParametersDefaultState;

		private VolumeStack m_DefaultStack;

		private readonly List<VolumeStack> m_CreatedVolumeStacks;

		public static VolumeManager instance => null;

		public VolumeStack stack { get; set; }

		[Obsolete("Please use baseComponentTypeArray instead. #from(2021.2)")]
		public IEnumerable<Type> baseComponentTypes => null;

		public Type[] baseComponentTypeArray
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public VolumeProfile globalDefaultProfile { get; private set; }

		public VolumeProfile qualityDefaultProfile { get; private set; }

		public ReadOnlyCollection<VolumeProfile> customDefaultProfiles { get; private set; }

		public bool isInitialized { get; private set; }

		[Obsolete("Please use the Register without a given layer index. #from(6000.0)")]
		public void Register(Volume volume, int layer)
		{
		}

		[Obsolete("Please use the Register without a given layer index. #from(6000.0)")]
		public void Unregister(Volume volume, int layer)
		{
		}

		internal List<(string, Type)> GetVolumeComponentsForDisplay(Type currentPipelineAssetType)
		{
			return null;
		}

		private List<(string, Type)> BuildVolumeComponentDisplayList(Type[] types)
		{
			return null;
		}

		public VolumeComponent GetVolumeComponentDefaultState(Type volumeComponentType)
		{
			return null;
		}

		internal VolumeManager()
		{
		}

		public void Initialize(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null)
		{
		}

		internal void InitializeInternal(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null)
		{
		}

		public void Deinitialize()
		{
		}

		public void SetGlobalDefaultProfile(VolumeProfile profile)
		{
		}

		public void SetQualityDefaultProfile(VolumeProfile profile)
		{
		}

		public void SetCustomDefaultProfiles(List<VolumeProfile> profiles)
		{
		}

		public void OnVolumeProfileChanged(VolumeProfile profile)
		{
		}

		public void OnVolumeComponentChanged(VolumeComponent component)
		{
		}

		public VolumeStack CreateStack()
		{
			return null;
		}

		private VolumeStack CreateStackInternal()
		{
			return null;
		}

		public void ResetMainStack()
		{
		}

		public void DestroyStack(VolumeStack stack)
		{
		}

		private bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(Type t, Type pipelineAssetType)
		{
			return false;
		}

		internal void LoadBaseTypes(Type pipelineAssetType)
		{
		}

		internal void InitializeVolumeComponents()
		{
		}

		private void EvaluateVolumeDefaultState()
		{
		}

		public void Register(Volume volume)
		{
		}

		public void Unregister(Volume volume)
		{
		}

		public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
		{
			return false;
		}

		internal void SetLayerDirty(int layer)
		{
		}

		internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer)
		{
		}

		private void OverrideData(VolumeStack stack, Volume volume, float interpFactor)
		{
		}

		internal void ReplaceData(VolumeStack stack)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void CheckDefaultVolumeState()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack)
		{
		}

		private bool CheckUpdateRequired(VolumeStack stack)
		{
			return false;
		}

		public void Update(Transform trigger, LayerMask layerMask)
		{
		}

		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask)
		{
		}

		public Volume[] GetVolumes(LayerMask layerMask)
		{
			return null;
		}

		private List<Volume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera)
		{
			return false;
		}
	}
}
