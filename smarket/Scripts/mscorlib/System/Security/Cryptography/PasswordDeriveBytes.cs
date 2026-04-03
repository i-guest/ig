using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Derives a key from a password using an extension of the PBKDF1 algorithm.</summary>
	[ComVisible(true)]
	public class PasswordDeriveBytes : DeriveBytes
	{
		private int _extraCount;

		private int _prefix;

		private int _iterations;

		private byte[] _baseValue;

		private byte[] _extra;

		private byte[] _salt;

		private string _hashName;

		private byte[] _password;

		private HashAlgorithm _hash;

		/// <summary>Gets or sets the name of the hash algorithm for the operation.</summary>
		/// <returns>The name of the hash algorithm for the operation.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The name of the hash value is fixed and an attempt is made to change this value. </exception>
		public string HashName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the number of iterations for the operation.</summary>
		/// <returns>The number of iterations for the operation.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The number of iterations is fixed and an attempt is made to change this value. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property cannot be set because its value is out of range. This property requires a non-negative number.</exception>
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
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key salt value is fixed and an attempt is made to change this value. </exception>
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

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password and key salt to use to derive the key.</summary>
		/// <param name="strPassword">The password for which to derive the key. </param>
		/// <param name="rgbSalt">The key salt to use to derive the key. </param>
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password and key salt to use to derive the key.</summary>
		/// <param name="password">The password to derive the key for.</param>
		/// <param name="salt">The key salt to use to derive the key.</param>
		public PasswordDeriveBytes(byte[] password, byte[] salt)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, hash name, and number of iterations to use to derive the key.</summary>
		/// <param name="strPassword">The password for which to derive the key. </param>
		/// <param name="rgbSalt">The key salt to use to derive the key. </param>
		/// <param name="strHashName">The name of the hash algorithm for the operation. </param>
		/// <param name="iterations">The number of iterations for the operation. </param>
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, hash name, and iterations to use to derive the key.</summary>
		/// <param name="password">The password to derive the key for.</param>
		/// <param name="salt">The key salt to use to derive the key.</param>
		/// <param name="hashName">The hash algorithm to use to derive the key.</param>
		/// <param name="iterations">The iteration count to use to derive the key.</param>
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, and cryptographic service provider (CSP) parameters to use to derive the key.</summary>
		/// <param name="strPassword">The password for which to derive the key. </param>
		/// <param name="rgbSalt">The key salt to use to derive the key. </param>
		/// <param name="cspParams">The CSP parameters for the operation. </param>
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, and cryptographic service provider (CSP) to use to derive the key.</summary>
		/// <param name="password">The password to derive the key for.</param>
		/// <param name="salt">The key salt to use to derive the key.</param>
		/// <param name="cspParams">The cryptographic service provider (CSP) parameters for the operation.</param>
		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, hash name, number of iterations, and cryptographic service provider (CSP) parameters to use to derive the key.</summary>
		/// <param name="strPassword">The password for which to derive the key. </param>
		/// <param name="rgbSalt">The key salt to use to derive the key. </param>
		/// <param name="strHashName">The name of the hash algorithm for the operation. </param>
		/// <param name="iterations">The number of iterations for the operation. </param>
		/// <param name="cspParams">The CSP parameters for the operation. </param>
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, hash name, iterations, and cryptographic service provider (CSP) to use to derive the key.</summary>
		/// <param name="password">The password to derive the key for.</param>
		/// <param name="salt">The key salt to use to derive the key.</param>
		/// <param name="hashName">The hash algorithm to use to derive the key.</param>
		/// <param name="iterations">The iteration count to use to derive the key.</param>
		/// <param name="cspParams">The cryptographic service provider (CSP) parameters for the operation.</param>
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
		}

		/// <summary>Returns pseudo-random key bytes.</summary>
		/// <param name="cb">The number of pseudo-random key bytes to generate. </param>
		/// <returns>A byte array filled with pseudo-random key bytes.</returns>
		[Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		/// <summary>Resets the state of the operation.</summary>
		public override void Reset()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Derives a cryptographic key from the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> object.</summary>
		/// <param name="algname">The algorithm name for which to derive the key. </param>
		/// <param name="alghashname">The hash algorithm name to use to derive the key. </param>
		/// <param name="keySize">The size of the key, in bits, to derive. </param>
		/// <param name="rgbIV">The initialization vector (IV) to use to derive the key. </param>
		/// <returns>The derived key.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="keySize" /> parameter is incorrect.-or- The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="algname" /> parameter is not a valid algorithm name.-or- The <paramref name="alghashname" /> parameter is not a valid hash algorithm name. </exception>
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		private byte[] ComputeBaseValue()
		{
			return null;
		}

		private byte[] ComputeBytes(int cb)
		{
			return null;
		}

		private void HashPrefix(CryptoStream cs)
		{
		}
	}
}
