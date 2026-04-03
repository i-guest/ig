using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryInfo" /> class on the specified path.</summary>
		/// <param name="path">A string specifying the path on which to create the <see langword="DirectoryInfo" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
		public DirectoryInfo(string path)
		{
		}

		internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
		}

		private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
		}

		/// <summary>Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.</summary>
		/// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
		/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <returns>An enumerable collection of files that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="searchPattern" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			return null;
		}

		private DirectoryInfo(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
