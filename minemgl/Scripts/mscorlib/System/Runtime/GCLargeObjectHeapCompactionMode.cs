namespace System.Runtime
{
	/// <summary>[Supported in the .NET Framework 4.5.1 and later versions] Indicates whether the next blocking garbage collection compacts the large object heap (LOH). </summary>
	public enum GCLargeObjectHeapCompactionMode
	{
		/// <summary>The large object heap (LOH) is not compacted.</summary>
		Default = 1,
		/// <summary>The large object heap (LOH) will be compacted during the next blocking generation 2 garbage collection. </summary>
		CompactOnce = 2
	}
}
