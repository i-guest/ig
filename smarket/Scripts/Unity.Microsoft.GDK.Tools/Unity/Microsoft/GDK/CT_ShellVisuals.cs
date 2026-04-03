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
	public class CT_ShellVisuals : INotifyPropertyChanged
	{
		private string defaultDisplayNameField;

		private string publisherDisplayNameField;

		private string storeLogoField;

		private string square150x150LogoField;

		private string square44x44LogoField;

		private string square480x480LogoField;

		private string descriptionField;

		private ST_ForegroundText foregroundTextField;

		private bool foregroundTextFieldSpecified;

		private string backgroundColorField;

		private string splashScreenImageField;

		[XmlAttribute]
		public string DefaultDisplayName
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
		public string PublisherDisplayName
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
		public string StoreLogo
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
		public string Square150x150Logo
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
		public string Square44x44Logo
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
		public string Square480x480Logo
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
		public string Description
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
		public ST_ForegroundText ForegroundText
		{
			get
			{
				return default(ST_ForegroundText);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool ForegroundTextSpecified
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
		public string BackgroundColor
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
		public string SplashScreenImage
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
