using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Serialization;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	public class ResourceManagerRuntimeData
	{
		public const string kCatalogAddress = "AddressablesMainContentCatalog";

		[SerializeField]
		private string m_buildTarget;

		[FormerlySerializedAs("m_settingsHash")]
		[SerializeField]
		private string m_SettingsHash;

		[FormerlySerializedAs("m_catalogLocations")]
		[SerializeField]
		private List<ResourceLocationData> m_CatalogLocations;

		[FormerlySerializedAs("m_logResourceManagerExceptions")]
		[SerializeField]
		private bool m_LogResourceManagerExceptions;

		[FormerlySerializedAs("m_extraInitializationData")]
		[SerializeField]
		private List<ObjectInitializationData> m_ExtraInitializationData;

		[SerializeField]
		private bool m_DisableCatalogUpdateOnStart;

		[SerializeField]
		private bool m_IsLocalCatalogInBundle;

		[SerializeField]
		private SerializedType m_CertificateHandlerType;

		[SerializeField]
		private string m_AddressablesVersion;

		[SerializeField]
		private int m_maxConcurrentWebRequests;

		[SerializeField]
		private int m_CatalogRequestsTimeout;

		public string BuildTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SettingsHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<ResourceLocationData> CatalogLocations => null;

		public bool LogResourceManagerExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<ObjectInitializationData> InitializationObjects => null;

		public bool DisableCatalogUpdateOnStartup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLocalCatalogInBundle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Type CertificateHandlerType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AddressablesVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxConcurrentWebRequests
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CatalogRequestsTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
