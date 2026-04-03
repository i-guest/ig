using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
	/// <summary>Represents the SMTP section in the <see langword="System.Net" /> configuration file.</summary>
	public sealed class SmtpSection : ConfigurationSection
	{
		/// <summary>Gets or sets the delivery format to use for sending outgoing e-mail using the Simple Mail Transport Protocol (SMTP).</summary>
		/// <returns>Returns <see cref="T:System.Net.Mail.SmtpDeliveryFormat" />.The delivery format to use for sending outgoing e-mail using SMTP.</returns>
		public SmtpDeliveryFormat DeliveryFormat
		{
			get
			{
				return default(SmtpDeliveryFormat);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the Simple Mail Transport Protocol (SMTP) delivery method. The default delivery method is <see cref="F:System.Net.Mail.SmtpDeliveryMethod.Network" />.</summary>
		/// <returns>A string that represents the SMTP delivery method.</returns>
		public SmtpDeliveryMethod DeliveryMethod
		{
			get
			{
				return default(SmtpDeliveryMethod);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the default value that indicates who the email message is from.</summary>
		/// <returns>A string that represents the default value indicating who a mail message is from.</returns>
		public string From
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the configuration element that controls the network settings used by the Simple Mail Transport Protocol (SMTP). file.<see cref="T:System.Net.Configuration.SmtpNetworkElement" />.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SmtpNetworkElement" /> object.The configuration element that controls the network settings used by SMTP.</returns>
		public SmtpNetworkElement Network => null;

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets the pickup directory that will be used by the SMPT client.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement" /> object that specifies the pickup directory folder.</returns>
		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SmtpSection" /> class.</summary>
		public SmtpSection()
		{
		}
	}
}
