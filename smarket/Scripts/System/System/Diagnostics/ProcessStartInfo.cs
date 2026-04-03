using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Specifies a set of values that are used when you start a process.</summary>
	[StructLayout((LayoutKind)0)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class ProcessStartInfo
	{
		private string fileName;

		private string arguments;

		private string directory;

		private string verb;

		private ProcessWindowStyle windowStyle;

		private bool errorDialog;

		private IntPtr errorDialogParentHandle;

		private bool useShellExecute;

		private string userName;

		private string domain;

		private SecureString password;

		private string passwordInClearText;

		private bool loadUserProfile;

		private bool redirectStandardInput;

		private bool redirectStandardOutput;

		private bool redirectStandardError;

		private Encoding standardOutputEncoding;

		private Encoding standardErrorEncoding;

		private bool createNoWindow;

		private WeakReference weakParentProcess;

		internal StringDictionary environmentVariables;

		private static readonly string[] empty;

		private Collection<string> _argumentList;

		private IDictionary<string, string> environment;

		public Collection<string> ArgumentList => null;

		/// <summary>Gets or sets the set of command-line arguments to use when starting the application.</summary>
		/// <returns>A single string containing the arguments to pass to the target application specified in the <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property. The default is an empty string (""). On Windows Vista and earlier versions of the Windows operating system, the length of the arguments added to the length of the full path to the process must be less than 2080. On Windows 7 and later versions, the length must be less than 32699.Arguments are parsed and interpreted by the target application, so must align with the expectations of that application. For.NET applications as demonstrated in the Examples below, spaces are interpreted as a separator between multiple arguments. A single argument that includes spaces must be surrounded by quotation marks, but those quotation marks are not carried through to the target application. In include quotation marks in the final parsed argument, triple-escape each mark.</returns>
		[NotifyParentProperty(true)]
		[SettingsBindable(true)]
		[DefaultValue(null)]
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string Arguments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets search paths for files, directories for temporary files, application-specific options, and other similar information.</summary>
		/// <returns>A string dictionary that provides environment variables that apply to this process and child processes. The default is <see langword="null" />.</returns>
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[DefaultValue(null)]
		[NotifyParentProperty(true)]
		public StringDictionary EnvironmentVariables => null;

		/// <summary>Gets or sets a value indicating whether the input for an application is read from the <see cref="P:System.Diagnostics.Process.StandardInput" /> stream.</summary>
		/// <returns>
		///     <see langword="true" /> if input should be read from <see cref="P:System.Diagnostics.Process.StandardInput" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardInput => false;

		/// <summary>Gets or sets a value that indicates whether the textual output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream.</summary>
		/// <returns>
		///     <see langword="true" /> if output should be written to <see cref="P:System.Diagnostics.Process.StandardOutput" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
		[DefaultValue(false)]
		public bool RedirectStandardOutput => false;

		/// <summary>Gets or sets a value that indicates whether the error output of an application is written to the <see cref="P:System.Diagnostics.Process.StandardError" /> stream.</summary>
		/// <returns>
		///     <see langword="true" /> if error output should be written to <see cref="P:System.Diagnostics.Process.StandardError" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardError => false;

		/// <summary>Gets or sets the preferred encoding for error output.</summary>
		/// <returns>An object that represents the preferred encoding for error output. The default is <see langword="null" />.</returns>
		public Encoding StandardErrorEncoding => null;

		/// <summary>Gets or sets the preferred encoding for standard output.</summary>
		/// <returns>An object that represents the preferred encoding for standard output. The default is <see langword="null" />.</returns>
		public Encoding StandardOutputEncoding => null;

		/// <summary>Gets or sets a value indicating whether to use the operating system shell to start the process.</summary>
		/// <returns>
		///     <see langword="true" /> if the shell should be used when starting the process; <see langword="false" /> if the process should be created directly from the executable file. The default is <see langword="true" />.</returns>
		[DefaultValue(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[NotifyParentProperty(true)]
		public bool UseShellExecute => false;

		/// <summary>Gets or sets the user name to be used when starting the process.</summary>
		/// <returns>The user name to use when starting the process.</returns>
		[NotifyParentProperty(true)]
		public string UserName => null;

		/// <summary>Gets or sets a secure string that contains the user password to use when starting the process.</summary>
		/// <returns>The user password to use when starting the process.</returns>
		public SecureString Password => null;

		/// <summary>Gets or sets a value that identifies the domain to use when starting the process. </summary>
		/// <returns>The Active Directory domain to use when starting the process. The domain property is primarily of interest to users within enterprise environments that use Active Directory.</returns>
		[NotifyParentProperty(true)]
		public string Domain => null;

		/// <summary>Gets or sets a value that indicates whether the Windows user profile is to be loaded from the registry. </summary>
		/// <returns>
		///     <see langword="true" /> if the Windows user profile should be loaded; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		[NotifyParentProperty(true)]
		public bool LoadUserProfile => false;

		/// <summary>Gets or sets the application or document to start.</summary>
		/// <returns>The name of the application to start, or the name of a document of a file type that is associated with an application and that has a default open action available to it. The default is an empty string ("").</returns>
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[DefaultValue(null)]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string FileName => null;

		/// <summary>When the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property is <see langword="false" />, gets or sets the working directory for the process to be started. When <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> is <see langword="true" />, gets or sets the directory that contains the process to be started.</summary>
		/// <returns>When <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> is <see langword="true" />, the fully qualified name of the directory that contains the process to be started. When the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property is <see langword="false" />, the working directory for the process to be started. The default is an empty string ("").</returns>
		[SettingsBindable(true)]
		[DefaultValue(null)]
		[MonitoringDescription("The initial working directory for the process.")]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[NotifyParentProperty(true)]
		public string WorkingDirectory => null;

		internal bool HaveEnvVars => false;

		public Encoding StandardInputEncoding { get; }

		internal ProcessStartInfo(Process parent)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ProcessStartInfo" /> class and specifies a file name such as an application or document with which to start the process.</summary>
		/// <param name="fileName">An application or document with which to start a process. </param>
		public ProcessStartInfo(string fileName)
		{
		}
	}
}
