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
	public class CT_MediaCapture : INotifyPropertyChanged
	{
		private bool gameDVRSystemComponentField;

		private bool gameDVRSystemComponentFieldSpecified;

		private bool blockBroadcastField;

		private bool blockBroadcastFieldSpecified;

		private bool blockGameDVRField;

		private bool blockGameDVRFieldSpecified;

		public bool GameDVRSystemComponent
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
		public bool GameDVRSystemComponentSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool BlockBroadcast
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
		public bool BlockBroadcastSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool BlockGameDVR
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
		public bool BlockGameDVRSpecified
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
