namespace System.Security.Cryptography
{
	/// <summary>Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on <see cref="T:System.Security.Cryptography.HMACSHA1" />.</summary>
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		private const int MinimumSaltSize = 8;

		private readonly byte[] _password;

		private byte[] _salt;

		private uint _iterations;

		private HMAC _hmac;

		private int _blockSize;

		private byte[] _buffer;

		private uint _block;

		private int _startIndex;

		private int _endIndex;

		public HashAlgorithmName HashAlgorithm { get; }

		/// <summary>Gets or sets the number of iterations for the operation.</summary>
		/// <returns>The number of iterations for the operation.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of iterations is less than 1. </exception>
		public int IterationCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the key salt value for the operation.</summary>
		/// <returns>The key salt value for the operation.</returns>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes. </exception>
		/// <exception cref="T:System.ArgumentNullException">The salt is <see langword="null" />. </exception>
		public byte[] Salt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt, and number of iterations to derive the key.</summary>
		/// <param name="password">The password used to derive the key. </param>
		/// <param name="salt">The key salt used to derive the key.</param>
		/// <param name="iterations">The number of iterations for the operation. </param>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception>
		/// <exception cref="T:System.ArgumentNullException">The password or salt is <see langword="null" />. </exception>
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		{
		}

		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password and salt to derive the key.</summary>
		/// <param name="password">The password used to derive the key. </param>
		/// <param name="salt">The key salt used to derive the key. </param>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception>
		/// <exception cref="T:System.ArgumentNullException">The password or salt is <see langword="null" />. </exception>
		public Rfc2898DeriveBytes(string password, byte[] salt)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt, and number of iterations to derive the key.</summary>
		/// <param name="password">The password used to derive the key. </param>
		/// <param name="salt">The key salt used to derive the key. </param>
		/// <param name="iterations">The number of iterations for the operation. </param>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception>
		/// <exception cref="T:System.ArgumentNullException">The password or salt is <see langword="null" />. </exception>
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		{
		}

		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using the password and salt size to derive the key.</summary>
		/// <param name="password">The password used to derive the key. </param>
		/// <param name="saltSize">The size of the random salt that you want the class to generate. </param>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes. </exception>
		/// <exception cref="T:System.ArgumentNullException">The password or salt is <see langword="null" />. </exception>
		public Rfc2898DeriveBytes(string password, int saltSize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt size, and number of iterations to derive the key.</summary>
		/// <param name="password">The password used to derive the key. </param>
		/// <param name="saltSize">The size of the random salt that you want the class to generate. </param>
		/// <param name="iterations">The number of iterations for the operation. </param>
		/// <exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception>
		/// <exception cref="T:System.ArgumentNullException">The password or salt is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="iterations " />is out of range. This parameter requires a non-negative number.</exception>
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		{
		}

		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Returns the pseudo-random key for this object.</summary>
		/// <param name="cb">The number of pseudo-random key bytes to generate. </param>
		/// <returns>A byte array filled with pseudo-random key bytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="cb " />is out of range. This parameter requires a non-negative number.</exception>
		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		/// <summary>Derives a cryptographic key from the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> object.</summary>
		/// <param name="algname">The algorithm name for which to derive the key.</param>
		/// <param name="alghashname">The hash algorithm name to use to derive the key.</param>
		/// <param name="keySize">The size of the key, in bits, to derive.</param>
		/// <param name="rgbIV">The initialization vector (IV) to use to derive the key.</param>
		/// <returns>The derived key.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="keySize" /> parameter is incorrect.-or- The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="algname" /> parameter is not a valid algorithm name.-or- The <paramref name="alghashname" /> parameter is not a valid hash algorithm name. </exception>
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		/// <summary>Resets the state of the operation.</summary>
		public override void Reset()
		{
		}

		private HMAC OpenHmac()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private byte[] Func()
		{
			return null;
		}
	}
}
