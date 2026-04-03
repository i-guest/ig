namespace System.Net.Sockets
{
	/// <summary>Presents UDP receive result information from a call to the <see cref="M:System.Net.Sockets.UdpClient.ReceiveAsync" /> method.</summary>
	public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
	{
		private byte[] m_buffer;

		private IPEndPoint m_remoteEndPoint;

		/// <summary>Gets a buffer with the data received in the UDP packet.</summary>
		/// <returns>Returns <see cref="T:System.Byte" />.A <see cref="T:System.Byte" /> array with the data received in the UDP packet.</returns>
		public byte[] Buffer => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.UdpReceiveResult" /> class.</summary>
		/// <param name="buffer">A buffer for data to receive in the UDP packet.</param>
		/// <param name="remoteEndPoint">The remote endpoint of the UDP packet.</param>
		public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint)
		{
			m_buffer = null;
			m_remoteEndPoint = null;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>Returns <see cref="T:System.Boolean" />.
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Net.Sockets.UdpReceiveResult" /> and equals the value of the instance; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="other">The object to compare with this instance.</param>
		/// <returns>Returns <see cref="T:System.Boolean" />.
		///     <see langword="true" /> if <paramref name="other" /> is an instance of <see cref="T:System.Net.Sockets.UdpReceiveResult" /> and equals the value of the instance; otherwise, <see langword="false" />.</returns>
		public bool Equals(UdpReceiveResult other)
		{
			return false;
		}
	}
}
