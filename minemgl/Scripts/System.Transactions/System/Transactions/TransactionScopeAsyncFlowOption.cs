namespace System.Transactions
{
	/// <summary>[Supported in the .NET Framework 4.5.1 and later versions] Specifies whether transaction flow across thread continuations is enabled for <see cref="T:System.Transactions.TransactionScope" />.</summary>
	public enum TransactionScopeAsyncFlowOption
	{
		/// <summary>Specifies that transaction flow across thread continuations is suppressed.</summary>
		Suppress = 0,
		/// <summary>Specifies that transaction flow across thread continuations is enabled.</summary>
		Enabled = 1
	}
}
