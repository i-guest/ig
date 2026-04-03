using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents an SMTP pickup directory configuration element.</summary>
	public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
	{
		/// <summary>Gets or sets the folder where applications save mail messages to be processed by the SMTP server.</summary>
		/// <returns>A string that specifies the pickup directory for e-mail messages.</returns>
		public string PickupDirectoryLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement" /> class.</summary>
		public SmtpSpecifiedPickupDirectoryElement()
		{
		}
	}
}
