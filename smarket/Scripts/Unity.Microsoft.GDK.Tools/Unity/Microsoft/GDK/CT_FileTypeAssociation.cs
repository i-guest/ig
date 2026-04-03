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
	public class CT_FileTypeAssociation : INotifyPropertyChanged
	{
		private string displayNameField;

		private string logoField;

		private string infoTipField;

		private CT_FileTypeAssociationEditFlags editFlagsField;

		private CT_FTASupportedFileTypesFileType[] supportedFileTypesField;

		private string nameField;

		private string executableField;

		public string DisplayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Logo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string InfoTip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_FileTypeAssociationEditFlags EditFlags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlArrayItem("FileType", IsNullable = false)]
		public CT_FTASupportedFileTypesFileType[] SupportedFileTypes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public string Executable
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
