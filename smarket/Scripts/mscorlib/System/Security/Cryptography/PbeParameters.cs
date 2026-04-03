namespace System.Security.Cryptography
{
	public sealed class PbeParameters
	{
		public PbeEncryptionAlgorithm EncryptionAlgorithm { get; }

		public HashAlgorithmName HashAlgorithm { get; }

		public int IterationCount { get; }

		public PbeParameters(PbeEncryptionAlgorithm encryptionAlgorithm, HashAlgorithmName hashAlgorithm, int iterationCount)
		{
		}
	}
}
