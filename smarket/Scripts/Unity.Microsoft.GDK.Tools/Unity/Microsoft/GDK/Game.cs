using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Unity.Microsoft.GDK
{
	[Serializable]
	[GeneratedCode("xsd", "4.8.3928.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = null, IsNullable = false)]
	public class Game : INotifyPropertyChanged
	{
		private CT_Identity identityField;

		private CT_ShellVisuals shellVisualsField;

		private CT_ResourcesResource[] resourcesField;

		private CT_ExecutableList executableListField;

		private string gameOsVersionField;

		private CT_MediaCapture mediaCaptureField;

		private string storeIdField;

		private ST_DeviceFamily targetDeviceFamilyForDLCField;

		private bool targetDeviceFamilyForDLCFieldSpecified;

		private CT_AllowedProductsList allowedProductsField;

		private CT_RelatedProductsList relatedProductsField;

		private CT_PersistentLocalStorage persistentLocalStorageField;

		private CT_VirtualMachine virtualMachineField;

		private bool mSAFullTrustField;

		private bool mSAFullTrustFieldSpecified;

		private string mSAAppIdField;

		private string titleIdField;

		private bool requiresXboxLiveField;

		private bool requiresXboxLiveFieldSpecified;

		private CT_ExtendedAttributeList extendedAttributeListField;

		private CT_DesktopRegistration desktopRegistrationField;

		private CT_DevelopmentOnly developmentOnlyField;

		private bool advancedUserModelField;

		private CT_SaveGameStorage saveGameStorageField;

		private CT_ProtocolList protocolListField;

		private string franchiseGameHubIdField;

		private string associatedFranchiseGameHubIdField;

		private string configVersionField;

		public CT_Identity Identity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_ShellVisuals ShellVisuals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlArrayItem("Resource", IsNullable = false)]
		public CT_ResourcesResource[] Resources
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_ExecutableList ExecutableList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string GameOsVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_MediaCapture MediaCapture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StoreId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ST_DeviceFamily TargetDeviceFamilyForDLC
		{
			get
			{
				return default(ST_DeviceFamily);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool TargetDeviceFamilyForDLCSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CT_AllowedProductsList AllowedProducts
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_RelatedProductsList RelatedProducts
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_PersistentLocalStorage PersistentLocalStorage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_VirtualMachine VirtualMachine
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MSAFullTrust
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool MSAFullTrustSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string MSAAppId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool RequiresXboxLive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool RequiresXboxLiveSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CT_ExtendedAttributeList ExtendedAttributeList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_DesktopRegistration DesktopRegistration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_DevelopmentOnly DevelopmentOnly
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DefaultValue(true)]
		public bool AdvancedUserModel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CT_SaveGameStorage SaveGameStorage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_ProtocolList ProtocolList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FranchiseGameHubId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AssociatedFranchiseGameHubId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute(DataType = "integer")]
		public string configVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
		}
	}
}
