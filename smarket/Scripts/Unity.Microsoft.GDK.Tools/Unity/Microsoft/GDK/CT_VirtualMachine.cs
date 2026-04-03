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
	public class CT_VirtualMachine : INotifyPropertyChanged
	{
		private ST_MemoryConfig xboxOneXTitleMemoryField;

		private bool xboxOneXTitleMemoryFieldSpecified;

		private ST_MemoryConfig xboxAnacondaTitleMemoryField;

		private bool xboxAnacondaTitleMemoryFieldSpecified;

		private bool sMTEnabledField;

		private bool sMTEnabledFieldSpecified;

		private bool requiresEraShimField;

		private bool requiresEraShimFieldSpecified;

		private ST_ConsoleGeneration xboxCompatibilityField;

		private bool xboxCompatibilityFieldSpecified;

		private ST_ConsoleGeneration dlcCompatibilityField;

		private bool dlcCompatibilityFieldSpecified;

		private ST_MemoryConfig xboxLockhartTitleMemoryField;

		private bool xboxLockhartTitleMemoryFieldSpecified;

		public ST_MemoryConfig XboxOneXTitleMemory
		{
			get
			{
				return default(ST_MemoryConfig);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool XboxOneXTitleMemorySpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ST_MemoryConfig XboxAnacondaTitleMemory
		{
			get
			{
				return default(ST_MemoryConfig);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool XboxAnacondaTitleMemorySpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SMTEnabled
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
		public bool SMTEnabledSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RequiresEraShim
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
		public bool RequiresEraShimSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ST_ConsoleGeneration XboxCompatibility
		{
			get
			{
				return default(ST_ConsoleGeneration);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool XboxCompatibilitySpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ST_ConsoleGeneration DlcCompatibility
		{
			get
			{
				return default(ST_ConsoleGeneration);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool DlcCompatibilitySpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ST_MemoryConfig XboxLockhartTitleMemory
		{
			get
			{
				return default(ST_MemoryConfig);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool XboxLockhartTitleMemorySpecified
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
