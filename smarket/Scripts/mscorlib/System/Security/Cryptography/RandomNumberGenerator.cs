using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract class from which all implementations of cryptographic random number generators derive.</summary>
	[ComVisible(true)]
	public abstract class RandomNumberGenerator : IDisposable
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.RandomNumberGenerator" />.</summary>
		protected RandomNumberGenerator()
		{
		}

		/// <summary>When overridden in a derived class, creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.</summary>
		/// <returns>A new instance of a cryptographic random number generator.</returns>
		public static RandomNumberGenerator Create()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, creates an instance of the specified implementation of a cryptographic random number generator.</summary>
		/// <param name="rngName">The name of the random number generator implementation to use. </param>
		/// <returns>A new instance of a cryptographic random number generator.</returns>
		public static RandomNumberGenerator Create(string rngName)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> class.</summary>
		public void Dispose()
		{
		}

		/// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of values.</summary>
		/// <param name="data">The array to fill with cryptographically strong random bytes. </param>
		public abstract void GetBytes(byte[] data);

		/// <summary>Fills the specified byte array with a cryptographically strong random sequence of values.</summary>
		/// <param name="data">The array to fill with cryptographically strong random bytes.</param>
		/// <param name="offset">The index of the array to start the fill operation.</param>
		/// <param name="count">The number of bytes to fill.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> or <paramref name="count" /> is less than 0</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" /> plus <paramref name="count" /> exceeds the length of <paramref name="data" />.</exception>
		public virtual void GetBytes(byte[] data, int offset, int count)
		{
		}

		/// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of nonzero values.</summary>
		/// <param name="data">The array to fill with cryptographically strong random nonzero bytes. </param>
		public virtual void GetNonZeroBytes(byte[] data)
		{
		}

		public static void Fill(Span<byte> data)
		{
		}

		internal static void FillSpan(Span<byte> data)
		{
		}

		public virtual void GetBytes(Span<byte> data)
		{
		}

		public virtual void GetNonZeroBytes(Span<byte> data)
		{
		}

		public static int GetInt32(int fromInclusive, int toExclusive)
		{
			return 0;
		}

		public static int GetInt32(int toExclusive)
		{
			return 0;
		}
	}
}
