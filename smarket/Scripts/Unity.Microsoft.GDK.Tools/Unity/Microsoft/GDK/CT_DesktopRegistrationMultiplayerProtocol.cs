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
	public class CT_DesktopRegistrationMultiplayerProtocol : INotifyPropertyChanged
	{
		private string executableField;

		private bool valueField;

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

		[XmlText]
		public bool Value
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
