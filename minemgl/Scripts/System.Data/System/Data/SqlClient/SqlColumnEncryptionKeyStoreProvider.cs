using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Base class for all key store providers. A custom provider must derive from this class and override its member functions and then register it using SqlConnection.RegisterColumnEncryptionKeyStoreProviders(). For details see, Always Encrypted.</summary>
	public abstract class SqlColumnEncryptionKeyStoreProvider
	{
		/// <summary>Initializes a new instance of the SqlColumnEncryptionKeyStoreProviderClass.</summary>
		protected SqlColumnEncryptionKeyStoreProvider()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Decrypts the specified encrypted value of a column encryption key. The encrypted value is expected to be encrypted using the column master key with the specified key path and using the specified algorithm.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm.</param>
		/// <param name="encryptedColumnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>Returns <see cref="T:System.Byte" />. The decrypted column encryption key.</returns>
		public abstract byte[] DecryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] encryptedColumnEncryptionKey);

		/// <summary>Encrypts a column encryption key using the column master key with the specified key path and using the specified algorithm.</summary>
		/// <param name="masterKeyPath">The master key path.</param>
		/// <param name="encryptionAlgorithm">The encryption algorithm.</param>
		/// <param name="columnEncryptionKey">The encrypted column encryption key.</param>
		/// <returns>Returns <see cref="T:System.Byte" />. The encrypted column encryption key.</returns>
		public abstract byte[] EncryptColumnEncryptionKey(string masterKeyPath, string encryptionAlgorithm, byte[] columnEncryptionKey);

		public virtual byte[] SignColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}

		public virtual bool VerifyColumnMasterKeyMetadata(string masterKeyPath, bool allowEnclaveComputations, byte[] signature)
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return default(bool);
		}
	}
}
