using Unity;

namespace System.Data.SqlClient
{
	/// <summary>The implementation of the key store provider for Windows Certificate Store. This class enables using certificates stored in the Windows Certificate Store as column master keys. For details, see Always Encrypted.</summary>
	public class SqlColumnEncryptionCertificateStoreProvider : SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>The provider name.</summary>
		/// <returns>The provider name.</returns>
		public const string ProviderName = "MSSQL_CERTIFICATE_STORE";

		/// <summary>Key store provider for Windows Certificate Store.</summary>
		public SqlColumnEncryptionCertificateStoreProvider()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Decrypts the specified encrypted value of a column encryption key. The encrypted value is expected to be encrypted using the certificate with the specified key path and using the specified algorithm. The format of the key path should be “Local Machine/My/&lt;certificate_thumbrint&gt;” or “Current User/My/&lt;certificate_thumbprint&gt;”.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm. Currently, the only valid value is: RSA_OAEP</param>
		/// <param name="encryptedColumnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>Returns <see cref="T:System.Byte" />. The decrypted column encryption key.</returns>
		public override byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Encrypts a column encryption key using the certificate with the specified key path and using the specified algorithm. The format of the key path should be “Local Machine/My/&lt;certificate_thumbrint&gt;” or “Current User/My/&lt;certificate_thumbprint&gt;”.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm. Currently, the only valid value is: RSA_OAEP</param>
		/// <param name="columnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>Returns <see cref="T:System.Byte" />. The encrypted column encryption key.</returns>
		public override byte[] EncryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] columnEncryptionKey)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}

		public override byte[] SignColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}

		public override bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}
	}
}
