using System.Collections.Generic;
using System.Text;

namespace System.IO
{
	/// <summary>Provides static methods for the creation, copying, deletion, moving, and opening of a single file, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	public static class File
	{
		/// <summary>Opens an existing UTF-8 encoded text file for reading.</summary>
		/// <param name="path">The file to be opened for reading. </param>
		/// <returns>A <see cref="T:System.IO.StreamReader" /> on the specified path.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static StreamReader OpenText(string path)
		{
			return null;
		}

		/// <summary>Creates or opens a file for writing UTF-8 encoded text.</summary>
		/// <param name="path">The file to be opened for writing. </param>
		/// <returns>A <see cref="T:System.IO.StreamWriter" /> that writes to the specified file using UTF-8 encoding.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static StreamWriter CreateText(string path)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.</summary>
		/// <param name="path">The path to the file to append to. </param>
		/// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static StreamWriter AppendText(string path)
		{
			return null;
		}

		/// <summary>Copies an existing file to a new file. Overwriting a file of the same name is not allowed.</summary>
		/// <param name="sourceFileName">The file to copy. </param>
		/// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file. </param>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- 
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> specifies a directory. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="sourceFileName" /> was not found. </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="destFileName" /> exists.-or- An I/O error has occurred. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
		public static void Copy(string sourceFileName, string destFileName)
		{
		}

		/// <summary>Copies an existing file to a new file. Overwriting a file of the same name is allowed.</summary>
		/// <param name="sourceFileName">The file to copy. </param>
		/// <param name="destFileName">The name of the destination file. This cannot be a directory. </param>
		/// <param name="overwrite">
		///       <see langword="true" /> if the destination file can be overwritten; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. -or-
		///         <paramref name="destFileName" /> is read-only.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- 
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> specifies a directory. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="sourceFileName" /> was not found. </exception>
		/// <exception cref="T:System.IO.IOException">
		///         <paramref name="destFileName" /> exists and <paramref name="overwrite" /> is <see langword="false" />.-or- An I/O error has occurred. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
		}

		/// <summary>Deletes the specified file. </summary>
		/// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">The specified file is in use. -or-There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- The file is an executable file that is in use.-or- 
		///         <paramref name="path" /> is a directory.-or- 
		///         <paramref name="path" /> specified a read-only file. </exception>
		public static void Delete(string path)
		{
		}

		/// <summary>Determines whether the specified file exists.</summary>
		/// <param name="path">The file to check. </param>
		/// <returns>
		///     <see langword="true" /> if the caller has the required permissions and <paramref name="path" /> contains the name of an existing file; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="path" /> is <see langword="null" />, an invalid path, or a zero-length string. If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the method returns <see langword="false" /> regardless of the existence of <paramref name="path" />.</returns>
		public static bool Exists(string path)
		{
			return false;
		}

		/// <summary>Opens a <see cref="T:System.IO.FileStream" /> on the specified path with read/write access.</summary>
		/// <param name="path">The file to open. </param>
		/// <param name="mode">A <see cref="T:System.IO.FileMode" /> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten. </param>
		/// <returns>A <see cref="T:System.IO.FileStream" /> opened in the specified mode and path, with read/write access and not shared.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. -or-
		///         <paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" /> and the specified file is a hidden file.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="mode" /> specified an invalid value. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static FileStream Open(string path, FileMode mode)
		{
			return null;
		}

		/// <summary>Opens a <see cref="T:System.IO.FileStream" /> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</summary>
		/// <param name="path">The file to open. </param>
		/// <param name="mode">A <see cref="T:System.IO.FileMode" /> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten. </param>
		/// <param name="access">A <see cref="T:System.IO.FileAccess" /> value that specifies the operations that can be performed on the file. </param>
		/// <param name="share">A <see cref="T:System.IO.FileShare" /> value specifying the type of access other threads have to the file. </param>
		/// <returns>A <see cref="T:System.IO.FileStream" /> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- 
		///         <paramref name="access" /> specified <see langword="Read" /> and <paramref name="mode" /> specified <see langword="Create" />, <see langword="CreateNew" />, <see langword="Truncate" />, or <see langword="Append" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only and <paramref name="access" /> is not <see langword="Read" />.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. -or-
		///         <paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" /> and the specified file is a hidden file.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="mode" />, <paramref name="access" />, or <paramref name="share" /> specified an invalid value. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return null;
		}

		/// <summary>Returns the creation date and time of the specified file or directory.</summary>
		/// <param name="path">The file or directory for which to obtain creation date and time information. </param>
		/// <returns>A <see cref="T:System.DateTime" /> structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static DateTime GetCreationTime(string path)
		{
			return default(DateTime);
		}

		/// <summary>Returns the date and time the specified file or directory was last accessed.</summary>
		/// <param name="path">The file or directory for which to obtain access date and time information. </param>
		/// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static DateTime GetLastAccessTime(string path)
		{
			return default(DateTime);
		}

		/// <summary>Returns the date and time the specified file or directory was last written to.</summary>
		/// <param name="path">The file or directory for which to obtain write date and time information. </param>
		/// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static DateTime GetLastWriteTime(string path)
		{
			return default(DateTime);
		}

		/// <summary>Gets the <see cref="T:System.IO.FileAttributes" /> of the file on the path.</summary>
		/// <param name="path">The path to the file. </param>
		/// <returns>The <see cref="T:System.IO.FileAttributes" /> of the file on the path.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="path" /> represents a file and is invalid, such as being on an unmapped drive, or the file cannot be found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///         <paramref name="path" /> represents a directory and is invalid, such as being on an unmapped drive, or the directory cannot be found.</exception>
		/// <exception cref="T:System.IO.IOException">This file is being used by another process.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
		public static FileAttributes GetAttributes(string path)
		{
			return default(FileAttributes);
		}

		/// <summary>Sets the specified <see cref="T:System.IO.FileAttributes" /> of the file on the specified path.</summary>
		/// <param name="path">The path to the file. </param>
		/// <param name="fileAttributes">A bitwise combination of the enumeration values. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is empty, contains only white spaces, contains invalid characters, or the file attribute is invalid. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission.</exception>
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
		}

		/// <summary>Opens an existing file for reading.</summary>
		/// <param name="path">The file to be opened for reading. </param>
		/// <returns>A read-only <see cref="T:System.IO.FileStream" /> on the specified path.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		public static FileStream OpenRead(string path)
		{
			return null;
		}

		/// <summary>Opens an existing file or creates a new file for writing.</summary>
		/// <param name="path">The file to be opened for writing. </param>
		/// <returns>An unshared <see cref="T:System.IO.FileStream" /> object on the specified path with <see cref="F:System.IO.FileAccess.Write" /> access.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- 
		///         <paramref name="path" /> specified a read-only file or directory. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		public static FileStream OpenWrite(string path)
		{
			return null;
		}

		/// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
		/// <param name="path">The file to open for reading. </param>
		/// <returns>A string containing all lines of the file.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static string ReadAllText(string path)
		{
			return null;
		}

		private static string InternalReadAllText(string path, Encoding encoding)
		{
			return null;
		}

		/// <summary>Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
		/// <param name="path">The file to write to. </param>
		/// <param name="contents">The string to write to the file. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" /> or <paramref name="contents" /> is empty.  </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static void WriteAllText(string path, string contents)
		{
		}

		/// <summary>Opens a binary file, reads the contents of the file into a byte array, and then closes the file.</summary>
		/// <param name="path">The file to open for reading. </param>
		/// <returns>A byte array containing the contents of the file.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		private static byte[] ReadAllBytesUnknownLength(FileStream fs)
		{
			return null;
		}

		/// <summary>Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
		/// <param name="path">The file to write to. </param>
		/// <param name="bytes">The bytes to write to the file. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" /> or the byte array is empty. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		private static void InternalWriteAllBytes(string path, byte[] bytes)
		{
		}

		/// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
		/// <param name="path">The file to open for reading. </param>
		/// <returns>A string array containing all lines of the file.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="path" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static string[] ReadAllLines(string path)
		{
			return null;
		}

		private static string[] InternalReadAllLines(string path, Encoding encoding)
		{
			return null;
		}

		/// <summary>Creates a new file, write the specified string array to the file, and then closes the file. </summary>
		/// <param name="path">The file to write to. </param>
		/// <param name="contents">The string array to write to the file. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">Either <paramref name="path" /> or <paramref name="contents" /> is <see langword="null" />.  </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- 
		///         <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public static void WriteAllLines(string path, string[] contents)
		{
		}

		/// <summary>Creates a new file, writes a collection of strings to the file, and then closes the file.</summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="contents">The lines to write to the file.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
		/// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path " />or <paramref name="contents" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///         <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		///         <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="path" /> is in an invalid format.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		///         <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-
		///         <paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
		public static void WriteAllLines(string path, IEnumerable<string> contents)
		{
		}

		private static void InternalWriteAllLines(TextWriter writer, IEnumerable<string> contents)
		{
		}

		/// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
		/// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
		/// <param name="destFileName">The new path and name for the file.</param>
		/// <exception cref="T:System.IO.IOException">The destination file already exists.-or-
		///         <paramref name="sourceFileName" /> was not found. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains invalid characters as defined in <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid, (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
		public static void Move(string sourceFileName, string destFileName)
		{
		}
	}
}
