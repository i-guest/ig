using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Provides the base class for both <see cref="T:System.IO.FileInfo" /> and <see cref="T:System.IO.DirectoryInfo" /> objects.</summary>
	[Serializable]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		private Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data;

		private int _dataInitialized;

		/// <summary>Represents the fully qualified path of the directory or file.</summary>
		/// <exception cref="T:System.IO.PathTooLongException">The fully qualified path is 260 or more characters.</exception>
		protected string FullPath;

		/// <summary>The path originally specified by the user, whether relative or absolute.</summary>
		protected string OriginalPath;

		internal string _name;

		/// <summary>Gets or sets the attributes for the current file or directory.</summary>
		/// <returns>
		///     <see cref="T:System.IO.FileAttributes" /> of the current <see cref="T:System.IO.FileSystemInfo" />.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">The specified file does not exist. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid; for example, it is on an unmapped drive. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The caller attempts to set an invalid file attribute. -or-The user attempts to set an attribute value but does not have write permission.</exception>
		/// <exception cref="T:System.IO.IOException">
		///         <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot initialize the data. </exception>
		public FileAttributes Attributes => default(FileAttributes);

		internal bool ExistsCore => false;

		internal DateTimeOffset LastWriteTimeCore => default(DateTimeOffset);

		internal long LengthCore => 0L;

		internal string NormalizedPath => null;

		/// <summary>Gets the full path of the directory or file.</summary>
		/// <returns>A string containing the full path.</returns>
		/// <exception cref="T:System.IO.PathTooLongException">The fully qualified path and file name is 260 or more characters.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public virtual string FullName => null;

		/// <summary>For files, gets the name of the file. For directories, gets the name of the last directory in the hierarchy if a hierarchy exists. Otherwise, the <see langword="Name" /> property gets the name of the directory.</summary>
		/// <returns>A string that is the name of the parent directory, the name of the last directory in the hierarchy, or the name of a file, including the file name extension.</returns>
		public virtual string Name => null;

		/// <summary>Gets a value indicating whether the file or directory exists.</summary>
		/// <returns>
		///     <see langword="true" /> if the file or directory exists; otherwise, <see langword="false" />.</returns>
		public virtual bool Exists => false;

		/// <summary>Gets or sets the time when the current file or directory was last written to.</summary>
		/// <returns>The time the current file was last written.</returns>
		/// <exception cref="T:System.IO.IOException">
		///         <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot initialize the data. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid write time.</exception>
		public DateTime LastWriteTime => default(DateTime);

		/// <summary>Gets or sets the time, in coordinated universal time (UTC), when the current file or directory was last written to.</summary>
		/// <returns>The UTC time when the current file was last written to.</returns>
		/// <exception cref="T:System.IO.IOException">
		///         <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot initialize the data. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid write time.</exception>
		public DateTime LastWriteTimeUtc => default(DateTime);

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemInfo" /> class.</summary>
		protected FileSystemInfo()
		{
		}

		internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData)
		{
			return null;
		}

		internal unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
		{
		}

		private void EnsureDataInitialized()
		{
		}

		/// <summary>Refreshes the state of the object.</summary>
		/// <exception cref="T:System.IO.IOException">A device such as a disk drive is not ready. </exception>
		public void Refresh()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemInfo" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> is null.</exception>
		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		[ComVisible(false)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
