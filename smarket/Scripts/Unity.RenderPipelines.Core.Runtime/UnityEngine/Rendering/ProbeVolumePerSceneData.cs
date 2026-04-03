using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[AddComponentMenu(null)]
	public class ProbeVolumePerSceneData : MonoBehaviour
	{
		[Serializable]
		internal struct ObsoletePerScenarioData
		{
			public int sceneHash;

			public TextAsset cellDataAsset;

			public TextAsset cellOptionalDataAsset;
		}

		[Serializable]
		private struct ObsoleteSerializablePerScenarioDataItem
		{
			public string scenario;

			public ObsoletePerScenarioData data;
		}

		[SerializeField]
		[FormerlySerializedAs("bakingSet")]
		internal ProbeVolumeBakingSet serializedBakingSet;

		[SerializeField]
		internal string sceneGUID;

		[FormerlySerializedAs("asset")]
		[SerializeField]
		internal ObsoleteProbeVolumeAsset obsoleteAsset;

		[FormerlySerializedAs("cellSharedDataAsset")]
		[SerializeField]
		internal TextAsset obsoleteCellSharedDataAsset;

		[FormerlySerializedAs("cellSupportDataAsset")]
		[SerializeField]
		internal TextAsset obsoleteCellSupportDataAsset;

		[FormerlySerializedAs("serializedScenarios")]
		[SerializeField]
		private List<ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios;

		public ProbeVolumeBakingSet bakingSet => null;

		internal void Clear()
		{
		}

		internal void QueueSceneLoading()
		{
		}

		internal void QueueSceneRemoval()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		internal void Initialize()
		{
		}

		internal bool ResolveCellData()
		{
			return false;
		}
	}
}
