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
	public class CT_DependencyList : INotifyPropertyChanged
	{
		private CT_DependencyListKnownDependency[] knownDependencyField;

		private CT_DependencyListDependency[] dependencyField;

		[XmlElement("KnownDependency")]
		public CT_DependencyListKnownDependency[] KnownDependency
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement("Dependency")]
		public CT_DependencyListDependency[] Dependency
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
