using System;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Tables
{
	public class AssetTableEntry : TableEntry
	{
		private string m_GuidCache;

		private string m_SubAssetNameCache;

		internal AsyncOperationHandle<Object[]> PreloadAsyncOperation { get; set; }

		internal AsyncOperationHandle AsyncOperation { get; set; }

		public string Address
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Guid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SubAssetName => null;

		public bool IsEmpty => false;

		public bool IsSubAsset => false;

		internal AssetTableEntry()
		{
		}

		public void RemoveFromTable()
		{
		}

		internal Type GetExpectedType()
		{
			return null;
		}

		public void SetAssetOverride<T>(T asset)
		{
		}
	}
}
