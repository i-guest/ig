using System.ComponentModel;
using System.IO;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	/// <summary>Provides access to local and remote processes and enables you to start and stop local system processes.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultEvent("Exited")]
	[DefaultProperty("StartInfo")]
	public class Process : Component
	{
		private enum StreamReadMode
		{
			undefined = 0,
			syncMode = 1,
			asyncMode = 2
		}

		private enum State
		{
			HaveId = 1,
			IsLocal = 2,
			IsNt = 4,
			HaveProcessInfo = 8,
			Exited = 16,
			Associated = 32,
			IsWin2k = 64,
			HaveNtProcessInfo = 12
		}

		private struct ProcInfo
		{
			public IntPtr process_handle;

			public int pid;

			public string[] envVariables;

			public string UserName;

			public string Domain;

			public IntPtr Password;

			public bool LoadUserProfile;
		}

		private bool haveProcessId;

		private int processId;

		private bool haveProcessHandle;

		private SafeProcessHandle m_processHandle;

		private bool isRemoteMachine;

		private string machineName;

		private int m_processAccess;

		private ProcessThreadCollection threads;

		private ProcessModuleCollection modules;

		private bool haveWorkingSetLimits;

		private bool havePriorityClass;

		private ProcessStartInfo startInfo;

		private bool watchForExit;

		private bool watchingForExit;

		private EventHandler onExited;

		private bool exited;

		private int exitCode;

		private bool signaled;

		private bool haveExitTime;

		private bool raisedOnExited;

		private RegisteredWaitHandle registeredWaitHandle;

		private WaitHandle waitHandle;

		private ISynchronizeInvoke synchronizingObject;

		private StreamReader standardOutput;

		private StreamWriter standardInput;

		private StreamReader standardError;

		private bool disposed;

		private StreamReadMode outputStreamReadMode;

		private StreamReadMode errorStreamReadMode;

		private StreamReadMode inputStreamReadMode;

		internal AsyncStreamReader output;

		internal AsyncStreamReader error;

		private string process_name;

		[Browsable(false)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		private bool Associated => false;

		/// <summary>Gets a value indicating whether the associated process has been terminated.</summary>
		/// <returns>
		///     <see langword="true" /> if the operating system process referenced by the <see cref="T:System.Diagnostics.Process" /> component has terminated; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">There is no process associated with the object. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The exit code for the process could not be retrieved. </exception>
		/// <exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.HasExited" /> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception>
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public bool HasExited => false;

		/// <summary>Gets the native handle of the associated process.</summary>
		/// <returns>The handle that the operating system assigned to the associated process when the process was started. The system uses this handle to keep track of process attributes.</returns>
		/// <exception cref="T:System.InvalidOperationException">The process has not been started or has exited. The <see cref="P:System.Diagnostics.Process.Handle" /> property cannot be read because there is no process associated with this <see cref="T:System.Diagnostics.Process" /> instance.-or- The <see cref="T:System.Diagnostics.Process" /> instance has been attached to a running process but you do not have the necessary permissions to get a handle with full access rights. </exception>
		/// <exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.Handle" /> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		public IntPtr Handle => (IntPtr)0;

		/// <summary>Gets the unique identifier for the associated process.</summary>
		/// <returns>The system-generated unique identifier of the process that is referenced by this <see cref="T:System.Diagnostics.Process" /> instance.</returns>
		/// <exception cref="T:System.InvalidOperationException">The process's <see cref="P:System.Diagnostics.Process.Id" /> property has not been set.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
		[MonitoringDescription("The unique identifier for the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Id => 0;

		/// <summary>Gets or sets the properties to pass to the <see cref="M:System.Diagnostics.Process.Start" /> method of the <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <returns>The <see cref="T:System.Diagnostics.ProcessStartInfo" /> that represents the data with which to start the process. These arguments include the name of the executable file or document used to start the process.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value that specifies the <see cref="P:System.Diagnostics.Process.StartInfo" /> is <see langword="null" />. </exception>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[MonitoringDescription("Specifies information used to start a process.")]
		[Browsable(false)]
		public ProcessStartInfo StartInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the object used to marshal the event handler calls that are issued as a result of a process exit event.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> used to marshal event handler calls that are issued as a result of an <see cref="E:System.Diagnostics.Process.Exited" /> event on the process.</returns>
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		[DefaultValue(null)]
		[Browsable(false)]
		public ISynchronizeInvoke SynchronizingObject => null;

		/// <summary>Gets the name of the process.</summary>
		/// <returns>The name that the system uses to identify the process to the user.</returns>
		/// <exception cref="T:System.InvalidOperationException">The process does not have an identifier, or no process is associated with the <see cref="T:System.Diagnostics.Process" />.-or- The associated process has exited. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
		/// <exception cref="T:System.NotSupportedException">The process is not on this computer.</exception>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		public string ProcessName => null;

		private static bool IsWindows => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Process" /> class.</summary>
		public Process()
		{
		}

		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
		}

		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
		}

		private void CompletionCallback(object context, bool wasSignaled)
		{
		}

		/// <summary>Release all resources used by this process.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Frees all the resources that are associated with this component.</summary>
		public void Close()
		{
		}

		private void EnsureState(State state)
		{
		}

		private void EnsureWatchingForExit()
		{
		}

		/// <summary>Gets a new <see cref="T:System.Diagnostics.Process" /> component and associates it with the currently active process.</summary>
		/// <returns>A new <see cref="T:System.Diagnostics.Process" /> component associated with the process resource that is running the calling application.</returns>
		public static Process GetCurrentProcess()
		{
			return null;
		}

		/// <summary>Raises the <see cref="E:System.Diagnostics.Process.Exited" /> event.</summary>
		protected void OnExited()
		{
		}

		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			return null;
		}

		private SafeProcessHandle GetProcessHandle(int access)
		{
			return null;
		}

		private SafeProcessHandle OpenProcessHandle(int access)
		{
			return null;
		}

		/// <summary>Discards any information about the associated process that has been cached inside the process component.</summary>
		public void Refresh()
		{
		}

		private void SetProcessHandle(SafeProcessHandle processHandle)
		{
		}

		private void SetProcessId(int processId)
		{
		}

		/// <summary>Starts (or reuses) the process resource that is specified by the <see cref="P:System.Diagnostics.Process.StartInfo" /> property of this <see cref="T:System.Diagnostics.Process" /> component and associates it with the component.</summary>
		/// <returns>
		///     <see langword="true" /> if a process resource is started; <see langword="false" /> if no new process resource is started (for example, if an existing process is reused).</returns>
		/// <exception cref="T:System.InvalidOperationException">No file name was specified in the <see cref="T:System.Diagnostics.Process" /> component's <see cref="P:System.Diagnostics.Process.StartInfo" />.-or- The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> member of the <see cref="P:System.Diagnostics.Process.StartInfo" /> property is <see langword="true" /> while <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" />, or <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> is <see langword="true" />. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception>
		public bool Start()
		{
			return false;
		}

		/// <summary>Starts a process resource by specifying the name of a document or application file and associates the resource with a new <see cref="T:System.Diagnostics.Process" /> component.</summary>
		/// <param name="fileName">The name of a document or application file to run in the process. </param>
		/// <returns>A new <see cref="T:System.Diagnostics.Process" /> that is associated with the process resource, or <see langword="null" /> if no process resource is started. Note that a new process that’s started alongside already running instances of the same process will be independent from the others. In addition, Start may return a non-null Process with its <see cref="P:System.Diagnostics.Process.HasExited" /> property already set to <see langword="true" />. In this case, the started process may have activated an existing instance of itself and then exited.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception>
		public static Process Start(string fileName)
		{
			return null;
		}

		/// <summary>Starts the process resource that is specified by the parameter containing process start information (for example, the file name of the process to start) and associates the resource with a new <see cref="T:System.Diagnostics.Process" /> component.</summary>
		/// <param name="startInfo">The <see cref="T:System.Diagnostics.ProcessStartInfo" /> that contains the information that is used to start the process, including the file name and any command-line arguments. </param>
		/// <returns>A new <see cref="T:System.Diagnostics.Process" /> that is associated with the process resource, or <see langword="null" /> if no process resource is started. Note that a new process that’s started alongside already running instances of the same process will be independent from the others. In addition, Start may return a non-null Process with its <see cref="P:System.Diagnostics.Process.HasExited" /> property already set to <see langword="true" />. In this case, the started process may have activated an existing instance of itself and then exited.</returns>
		/// <exception cref="T:System.InvalidOperationException">No file name was specified in the <paramref name="startInfo" /> parameter's <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property.-or- The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property of the <paramref name="startInfo" /> parameter is <see langword="true" /> and the <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" />, or <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> property is also <see langword="true" />.-or-The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property of the <paramref name="startInfo" /> parameter is <see langword="true" /> and the <see cref="P:System.Diagnostics.ProcessStartInfo.UserName" /> property is not <see langword="null" /> or empty or the <see cref="P:System.Diagnostics.ProcessStartInfo.Password" /> property is not <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="startInfo" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified in the <paramref name="startInfo" /> parameter's <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> property could not be found.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file. -or-The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error message associated with this exception can be one of the following: "The data area passed to a system call is too small." or "Access is denied."</exception>
		public static Process Start(ProcessStartInfo startInfo)
		{
			return null;
		}

		private void StopWatchingForExit()
		{
		}

		/// <summary>Formats the process's name as a string, combined with the parent component type, if applicable.</summary>
		/// <returns>The <see cref="P:System.Diagnostics.Process.ProcessName" />, combined with the base component's <see cref="M:System.Object.ToString" /> return value.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///         <see cref="M:System.Diagnostics.Process.ToString" /> is not supported on Windows 98.</exception>
		public override string ToString()
		{
			return null;
		}

		private static string ProcessName_icall(IntPtr handle)
		{
			return null;
		}

		private static string ProcessName_internal(SafeProcessHandle handle)
		{
			return null;
		}

		private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo)
		{
			return false;
		}

		private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref ProcInfo procInfo)
		{
			return false;
		}

		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			return false;
		}

		private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
		{
			read = default(IntPtr);
			write = default(IntPtr);
		}

		private bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			return false;
		}

		private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo)
		{
		}

		private void RaiseOnExited()
		{
		}
	}
}
