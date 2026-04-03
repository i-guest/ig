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
	public class CT_SaveGameStorage : INotifyPropertyChanged
	{
		private CT_SaveGameStorageNoCodePCRoot noCodePCRootField;

		private string sCIDField;

		private string maxUserQuotaField;

		public CT_SaveGameStorageNoCodePCRoot NoCodePCRoot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SCID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement(DataType = "integer")]
		public string MaxUserQuota
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
