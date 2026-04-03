using System.Net.Security;
using System.Net.Sockets;

namespace System.Net.Configuration
{
	internal sealed class SettingsSectionInternal
	{
		private static readonly SettingsSectionInternal instance;

		internal readonly bool HttpListenerUnescapeRequestUrl;

		internal readonly IPProtectionLevel IPProtectionLevel;

		internal static SettingsSectionInternal Section => null;

		internal bool UseNagleAlgorithm { get; set; }

		internal bool Expect100Continue { get; set; }

		internal bool CheckCertificateName { get; private set; }

		internal int DnsRefreshTimeout { get; set; }

		internal bool EnableDnsRoundRobin { get; set; }

		internal bool CheckCertificateRevocationList { get; set; }

		internal EncryptionPolicy EncryptionPolicy { get; private set; }

		internal bool Ipv6Enabled => false;
	}
}
