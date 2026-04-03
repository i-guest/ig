namespace System.Diagnostics
{
	/// <summary>Provides a set of methods and properties that help debug your code.</summary>
	public static class Debug
	{
		/// <summary>Writes a message followed by a line terminator to the trace listeners in the <see cref="P:System.Diagnostics.Debug.Listeners" /> collection.</summary>
		/// <param name="message">A message to write. </param>
		[Conditional("DEBUG")]
		public static void WriteLine(string message)
		{
		}
	}
}
