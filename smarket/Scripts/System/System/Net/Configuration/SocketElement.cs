using System.Configuration;
using System.Net.Sockets;

namespace System.Net.Configuration
{
	/// <summary>Represents information used to configure <see cref="T:System.Net.Sockets.Socket" /> objects. This class cannot be inherited.</summary>
	public sealed class SocketElement : ConfigurationElement
	{
		/// <summary>Gets or sets a Boolean value that specifies whether completion ports are used when accepting connections.</summary>
		/// <returns>
		///     <see langword="true" /> to use completion ports; otherwise, <see langword="false" />.</returns>
		public bool AlwaysUseCompletionPortsForAccept
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that specifies whether completion ports are used when making connections.</summary>
		/// <returns>
		///     <see langword="true" /> to use completion ports; otherwise, <see langword="false" />.</returns>
		public bool AlwaysUseCompletionPortsForConnect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that specifies the default <see cref="T:System.Net.Sockets.IPProtectionLevel" /> to use for a socket.</summary>
		/// <returns>The value of the <see cref="T:System.Net.Sockets.IPProtectionLevel" /> for the current instance.</returns>
		public IPProtectionLevel IPProtectionLevel
		{
			get
			{
				return default(IPProtectionLevel);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SocketElement" /> class. </summary>
		public SocketElement()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
