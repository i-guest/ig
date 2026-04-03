using Unity;

namespace System.Data.SqlClient
{
	/// <summary>The CMK Store provider implementation for using the Microsoft Cryptography API: Next Generation (CNG) with Always Encrypted.   </summary>
	public class SqlColumnEncryptionCngProvider : SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>A constant string for the provider name 'MSSQL_CNG_STORE'.</summary>
		/// <returns>The provider name.</returns>
		public const string ProviderName = "MSSQL_CNG_STORE";

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlClient.SqlColumnEncryptionCngProvider" /> class.</summary>
		public SqlColumnEncryptionCngProvider()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Decrypts the given encrypted value using an asymmetric key specified by the key path and the specified algorithm. The key path will be in the format of [ProviderName]/KeyIdentifier and should be an asymmetric key stored in the specified CNG key store provider. The valid algorithm used to encrypt/decrypt the CEK is 'RSA_OAEP'.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm.</param>
		/// <param name="encryptedColumnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>The decrypted column encryption key.</returns>
		public override byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Encrypts the given plain text column encryption key using an asymmetric key specified by the key path and the specified algorithm. The key path will be in the format of [ProviderName]/KeyIdentifier and should be an asymmetric key stored in the specified CNG key store provider. The valid algorithm used to encrypt/decrypt the CEK is 'RSA_OAEP'.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm.</param>
		/// <param name="columnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>The encrypted column encryption key.</returns>
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
