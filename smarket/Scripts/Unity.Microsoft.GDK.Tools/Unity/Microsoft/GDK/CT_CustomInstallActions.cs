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
	public class CT_CustomInstallActions : INotifyPropertyChanged
	{
		private string folderField;

		private CT_InstallActionList installActionListField;

		private CT_RepairActionList repairActionListField;

		private CT_UninstallActionList uninstallActionListField;

		public string Folder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_InstallActionList InstallActionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_RepairActionList RepairActionList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CT_UninstallActionList UninstallActionList
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
