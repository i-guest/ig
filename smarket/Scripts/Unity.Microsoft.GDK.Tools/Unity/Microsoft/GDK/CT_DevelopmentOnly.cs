using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Microsoft.GDK
{
	[Serializable]
	[GeneratedCode("xsd", "4.8.3928.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class CT_DevelopmentOnly : INotifyPropertyChanged
	{
		private string contentIdOverrideField;

		private string eKBIDOverrideField;

		private CT_DebugNetworkPortList debugNetworkPortListField;

		public string ContentIdOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string EKBIDOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_DebugNetworkPortList DebugNetworkPortList
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
