using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.WebSockets
{
	/// <summary>Options to use with a  <see cref="T:System.Net.WebSockets.ClientWebSocket" /> object.</summary>
	public sealed class ClientWebSocketOptions
	{
		private bool _isReadOnly;

		private readonly List<string> _requestedSubProtocols;

		private readonly WebHeaderCollection _requestHeaders;

		private TimeSpan _keepAliveInterval;

		private IWebProxy _proxy;

		private X509CertificateCollection _clientCertificates;

		private CookieContainer _cookies;

		private int _receiveBufferSize;

		private int _sendBufferSize;

		private ArraySegment<byte>? _buffer;

		internal WebHeaderCollection RequestHeaders => null;

		internal List<string> RequestedSubProtocols => null;

		/// <summary>Gets or sets the proxy for WebSocket requests.</summary>
		/// <returns>Returns <see cref="T:System.Net.IWebProxy" />.The proxy for WebSocket requests.</returns>
		public IWebProxy Proxy
		{
			set
			{
			}
		}

		/// <summary>Gets or sets a collection of client side certificates.</summary>
		/// <returns>Returns <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />.A collection of client side certificates.</returns>
		public X509CertificateCollection ClientCertificates => null;

		/// <summary>Gets or sets the cookies associated with the request.</summary>
		/// <returns>Returns <see cref="T:System.Net.CookieContainer" />.The cookies associated with the request.</returns>
		public CookieContainer Cookies => null;

		/// <summary>Gets or sets the WebSocket protocol keep-alive interval in milliseconds.</summary>
		/// <returns>Returns <see cref="T:System.TimeSpan" />.The WebSocket protocol keep-alive interval in milliseconds.</returns>
		public TimeSpan KeepAliveInterval => default(TimeSpan);

		internal int ReceiveBufferSize => 0;

		internal int SendBufferSize => 0;

		internal ArraySegment<byte>? Buffer => null;

		internal ClientWebSocketOptions()
		{
		}

		/// <summary>Adds a sub-protocol to be negotiated during the WebSocket connection handshake.</summary>
		/// <param name="subProtocol">The WebSocket sub-protocol to add.</param>
		public void AddSubProtocol(string subProtocol)
		{
		}

		internal void SetToReadOnly()
		{
		}

		private void ThrowIfReadOnly()
		{
		}
	}
}
