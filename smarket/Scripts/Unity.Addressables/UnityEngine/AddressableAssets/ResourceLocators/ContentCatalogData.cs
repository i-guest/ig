using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	public class ContentCatalogData
	{
		internal class Serializer : BinaryStorageBuffer.ISerializationAdapter<ContentCatalogData>, BinaryStorageBuffer.ISerializationAdapter
		{
			private bool resolveInternalIds;

			public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies => null;

			public Serializer WithInternalIdResolvingDisabled()
			{
				return null;
			}

			public object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset, out uint size)
			{
				size = default(uint);
				return null;
			}

			public uint Serialize(BinaryStorageBuffer.Writer writer, object val)
			{
				return 0u;
			}
		}

		internal class ResourceLocator : IResourceLocator
		{
			public struct Header
			{
				public int magic;

				public int version;

				public uint keysOffset;

				public uint idOffset;

				public uint instanceProvider;

				public uint sceneProvider;

				public uint initObjectsArray;

				public uint buildResultHash;
			}

			public struct KeyData
			{
				public uint keyNameOffset;

				public uint locationSetOffset;
			}

			internal class ContentCatalogDataEntrySerializationContext
			{
				public ContentCatalogDataEntry entry;

				public Dictionary<object, List<int>> keyToEntryIndices;

				public IList<ContentCatalogDataEntry> allEntries;
			}

			internal class ResourceLocation : IResourceLocation
			{
				private class ResolvedInternalId
				{
					public string InternalId;
				}

				public class ResolvedInternalIdSerializer : BinaryStorageBuffer.ISerializationAdapter<ResolvedInternalId>, BinaryStorageBuffer.ISerializationAdapter
				{
					IEnumerable<BinaryStorageBuffer.ISerializationAdapter> BinaryStorageBuffer.ISerializationAdapter.Dependencies => null;

					object BinaryStorageBuffer.ISerializationAdapter.Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset, out uint size)
					{
						size = default(uint);
						return null;
					}

					uint BinaryStorageBuffer.ISerializationAdapter.Serialize(BinaryStorageBuffer.Writer writer, object val)
					{
						return 0u;
					}
				}

				public class Serializer : BinaryStorageBuffer.ISerializationAdapter<ResourceLocation>, BinaryStorageBuffer.ISerializationAdapter, BinaryStorageBuffer.ISerializationAdapter<ContentCatalogDataEntrySerializationContext>
				{
					public struct Data
					{
						public uint primaryKeyOffset;

						public uint internalIdOffset;

						public uint providerOffset;

						public uint dependencySetOffset;

						public int dependencyHashValue;

						public uint extraDataOffset;

						public uint typeId;
					}

					private bool resolveInternalIds;

					public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies => null;

					public Serializer(bool resolveInternalIds)
					{
					}

					public object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset, out uint size)
					{
						size = default(uint);
						return null;
					}

					public uint Serialize(BinaryStorageBuffer.Writer writer, object val)
					{
						return 0u;
					}
				}

				private BinaryStorageBuffer.Reader reader;

				private List<IResourceLocation> _deps;

				private uint dependencyDataOffset;

				public string InternalId { get; internal set; }

				public string ProviderId { get; internal set; }

				public IList<IResourceLocation> Dependencies => null;

				public int DependencyHashCode => 0;

				public bool HasDependencies => false;

				public object Data { get; internal set; }

				public string PrimaryKey { get; internal set; }

				public Type ResourceType { get; internal set; }

				public ResourceLocation(BinaryStorageBuffer.Reader r, uint id, out uint size, bool resolveInternalId)
				{
					size = default(uint);
				}

				private static void ProcDependencies(ResourceLocation l, ResourceLocation d, int i, int count)
				{
				}

				public override string ToString()
				{
					return null;
				}

				public int Hash(Type resultType)
				{
					return 0;
				}
			}

			private class LocateProcContext
			{
				public IList<IResourceLocation> locations;

				public Type type;
			}

			private Dictionary<object, uint> keyData;

			private BinaryStorageBuffer.Reader reader;

			private string providerSuffix;

			private LocateProcContext sharedContext;

			public string LocatorId { get; private set; }

			public IEnumerable<object> Keys => null;

			public IEnumerable<IResourceLocation> AllLocations => null;

			internal ResourceLocator(string id, BinaryStorageBuffer.Reader reader, string providerSuffix)
			{
			}

			private static void ProcFunc(ResourceLocation loc, LocateProcContext context, int i, int count)
			{
			}

			public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
			{
				locations = null;
				return false;
			}
		}

		internal class AssetBundleRequestOptionsSerializationAdapter : BinaryStorageBuffer.ISerializationAdapter<AssetBundleRequestOptions>, BinaryStorageBuffer.ISerializationAdapter
		{
			private struct SerializedData
			{
				public struct Common
				{
					public short timeout;

					public byte redirectLimit;

					public byte retryCount;

					public int flags;

					public AssetLoadMode assetLoadMode
					{
						get
						{
							return default(AssetLoadMode);
						}
						set
						{
						}
					}

					public bool chunkedTransfer
					{
						get
						{
							return false;
						}
						set
						{
						}
					}

					public bool useCrcForCachedBundle
					{
						get
						{
							return false;
						}
						set
						{
						}
					}

					public bool useUnityWebRequestForLocalBundles
					{
						get
						{
							return false;
						}
						set
						{
						}
					}

					public bool clearOtherCachedVersionsWhenLoaded
					{
						get
						{
							return false;
						}
						set
						{
						}
					}
				}

				public uint hashId;

				public uint bundleNameId;

				public uint crc;

				public uint bundleSize;

				public uint commonId;
			}

			public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies => null;

			public object Deserialize(BinaryStorageBuffer.Reader reader, Type type, uint offset, out uint size)
			{
				size = default(uint);
				return null;
			}

			public uint Serialize(BinaryStorageBuffer.Writer writer, object obj)
			{
				return 0u;
			}
		}

		private static int kMagic;

		private const int kVersion = 2;

		[NonSerialized]
		public string LocalHash;

		[NonSerialized]
		internal IResourceLocation location;

		[SerializeField]
		internal string m_LocatorId;

		[SerializeField]
		internal string m_BuildResultHash;

		[SerializeField]
		private ObjectInitializationData m_InstanceProviderData;

		[SerializeField]
		private ObjectInitializationData m_SceneProviderData;

		[SerializeField]
		internal List<ObjectInitializationData> m_ResourceProviderData;

		private IList<ContentCatalogDataEntry> m_Entries;

		private BinaryStorageBuffer.Reader m_Reader;

		public string BuildResultHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProviderId
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ObjectInitializationData InstanceProviderData
		{
			get
			{
				return default(ObjectInitializationData);
			}
			set
			{
			}
		}

		public ObjectInitializationData SceneProviderData
		{
			get
			{
				return default(ObjectInitializationData);
			}
			set
			{
			}
		}

		public List<ObjectInitializationData> ResourceProviderData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ContentCatalogData(string id)
		{
		}

		public ContentCatalogData()
		{
		}

		internal void CleanData()
		{
		}

		internal void CopyToFile(string path)
		{
		}

		internal ContentCatalogData(BinaryStorageBuffer.Reader reader)
		{
		}

		internal byte[] GetBytes()
		{
			return null;
		}

		internal IResourceLocator CreateCustomLocator(string overrideId = "", string providerSuffix = null)
		{
			return null;
		}

		internal static ContentCatalogData LoadFromFile(string path, bool resolveInternalIds)
		{
			return null;
		}
	}
}
