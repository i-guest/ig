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
	public class CT_DesktopRegistration : INotifyPropertyChanged
	{
		private ST_ProcessorArchitecture[] processorArchitectureField;

		private CT_DesktopRegistrationMainPackageDependency[] mainPackageDependencyField;

		private CT_DependencyList[] dependencyListField;

		private CT_CustomInstallActions[] customInstallActionsField;

		private CT_DesktopRegistrationModFolder[] modFolderField;

		private bool[] disableRegistryWriteVirtualizationField;

		private bool[] disableFilesystemWriteVirtualizationField;

		private bool[] enableWritesToPackageRootField;

		private CT_DesktopRegistrationMultiplayerProtocol[] multiplayerProtocolField;

		private CT_FileTypeAssociation[] fileTypeAssociationField;

		[XmlElement("ProcessorArchitecture")]
		public ST_ProcessorArchitecture[] ProcessorArchitecture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("MainPackageDependency")]
		public CT_DesktopRegistrationMainPackageDependency[] MainPackageDependency
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("DependencyList")]
		public CT_DependencyList[] DependencyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("CustomInstallActions")]
		public CT_CustomInstallActions[] CustomInstallActions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("ModFolder")]
		public CT_DesktopRegistrationModFolder[] ModFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("DisableRegistryWriteVirtualization")]
		public bool[] DisableRegistryWriteVirtualization
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("DisableFilesystemWriteVirtualization")]
		public bool[] DisableFilesystemWriteVirtualization
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("EnableWritesToPackageRoot")]
		public bool[] EnableWritesToPackageRoot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("MultiplayerProtocol")]
		public CT_DesktopRegistrationMultiplayerProtocol[] MultiplayerProtocol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("FileTypeAssociation")]
		public CT_FileTypeAssociation[] FileTypeAssociation
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
