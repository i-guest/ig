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
	public class CT_PersistentLocalStorage : INotifyPropertyChanged
	{
		private string sizeMBField;

		private string growableToMBField;

		private bool shareableField;

		private bool shareableFieldSpecified;

		[XmlElement(DataType = "integer")]
		public string SizeMB
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
		public string GrowableToMB
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Shareable
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
		public bool ShareableSpecified
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
