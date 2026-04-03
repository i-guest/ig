namespace System.Security.Cryptography
{
	internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
	{
		private string _hashAlgorithm;

		protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		{
		}

		public sealed override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		public sealed override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			return null;
		}
	}
}
