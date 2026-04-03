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
	public class CT_FileTypeAssociationEditFlags : INotifyPropertyChanged
	{
		private bool openIsSafeField;

		private bool openIsSafeFieldSpecified;

		private bool alwaysUnsafeField;

		private bool alwaysUnsafeFieldSpecified;

		[XmlAttribute]
		public bool OpenIsSafe
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
		public bool OpenIsSafeSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public bool AlwaysUnsafe
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
		public bool AlwaysUnsafeSpecified
		{
			get
			{
				return false;
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
