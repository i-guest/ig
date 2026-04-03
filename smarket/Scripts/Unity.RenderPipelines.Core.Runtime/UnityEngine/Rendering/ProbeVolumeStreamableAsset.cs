using System;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[Serializable]
	[MovedFrom(false, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset")]
	internal class ProbeVolumeStreamableAsset
	{
		[Serializable]
		[MovedFrom(false, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset.StreamableCellDesc")]
		public struct StreamableCellDesc
		{
			public int offset;

			public int elementCount;
		}

		[SerializeField]
		[FormerlySerializedAs("assetGUID")]
		private string m_AssetGUID;

		[SerializeField]
		[FormerlySerializedAs("streamableAssetPath")]
		private string m_StreamableAssetPath;

		[SerializeField]
		[FormerlySerializedAs("elementSize")]
		private int m_ElementSize;

		[SerializeField]
		[FormerlySerializedAs("streamableCellDescs")]
		private SerializedDictionary<int, StreamableCellDesc> m_StreamableCellDescs;

		[SerializeField]
		private TextAsset m_Asset;

		private string m_FinalAssetPath;

		private FileHandle m_AssetFileHandle;

		public string assetGUID => null;

		public TextAsset asset => null;

		public int elementSize => 0;

		public SerializedDictionary<int, StreamableCellDesc> streamableCellDescs => null;

		public ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, SerializedDictionary<int, StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID)
		{
		}

		internal void RefreshAssetPath()
		{
		}

		public string GetAssetPath()
		{
			return null;
		}

		internal bool HasValidAssetReference()
		{
			return false;
		}

		public bool FileExists()
		{
			return false;
		}

		public long GetFileSize()
		{
			return 0L;
		}

		public bool IsOpen()
		{
			return false;
		}

		public FileHandle OpenFile()
		{
			return default(FileHandle);
		}

		public void CloseFile()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
