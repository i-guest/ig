namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents the chain policy to be applied when building an X509 certificate chain. This class cannot be inherited.</summary>
	public sealed class X509ChainPolicy
	{
		private OidCollection apps;

		private OidCollection cert;

		private X509CertificateCollection store;

		private X509Certificate2Collection store2;

		private X509RevocationFlag rflag;

		private X509RevocationMode mode;

		private TimeSpan timeout;

		private X509VerificationFlags vflags;

		private DateTime vtime;

		/// <summary>Represents an additional collection of certificates that can be searched by the chaining engine when validating a certificate chain.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		public X509Certificate2Collection ExtraStore
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		/// <summary>Gets or sets values for X509 revocation flags.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> value supplied is not a valid flag. </exception>
		public X509RevocationFlag RevocationFlag => default(X509RevocationFlag);

		/// <summary>Gets or sets values for X509 certificate revocation mode.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> value supplied is not a valid flag. </exception>
		public X509RevocationMode RevocationMode
		{
			get
			{
				return default(X509RevocationMode);
			}
			set
			{
			}
		}

		/// <summary>Gets verification flags for the certificate.</summary>
		/// <returns>A value from the <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> enumeration.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> value supplied is not a valid flag. <see cref="F:System.Security.Cryptography.X509Certificates.X509VerificationFlags.NoFlag" /> is the default value. </exception>
		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return default(X509VerificationFlags);
			}
			set
			{
			}
		}

		/// <summary>The time that the certificate was verified expressed in local time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object.</returns>
		public DateTime VerificationTime => default(DateTime);

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> class. </summary>
		public X509ChainPolicy()
		{
		}

		/// <summary>Resets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> members to their default values.</summary>
		public void Reset()
		{
		}
	}
}
