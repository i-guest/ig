using System.Diagnostics;

namespace System.Threading.Tasks
{
	/// <summary>Represents an object that handles the low-level work of queuing tasks onto threads.</summary>
	[DebuggerDisplay("Id={Id}")]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}

		private static readonly TaskScheduler s_defaultTaskScheduler;

		internal static int s_taskSchedulerIdCounter;

		private int m_taskSchedulerId;

		private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		private static readonly Lock _unobservedTaskExceptionLockObject;

		internal virtual bool RequiresAtomicStartTransition => false;

		/// <summary>Gets the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance that is provided by the .NET Framework.</summary>
		/// <returns>Returns the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance.</returns>
		public static TaskScheduler Default => null;

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</summary>
		/// <returns>Returns the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</returns>
		public static TaskScheduler Current => null;

		internal static TaskScheduler InternalCurrent => null;

		/// <summary>Gets the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <returns>Returns the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</returns>
		public int Id => 0;

		/// <summary>Queues a <see cref="T:System.Threading.Tasks.Task" /> to the scheduler. </summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be queued.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		protected internal abstract void QueueTask(Task task);

		/// <summary>Determines whether the provided <see cref="T:System.Threading.Tasks.Task" /> can be executed synchronously in this call, and if it can, executes it.</summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be executed.</param>
		/// <param name="taskWasPreviouslyQueued">A Boolean denoting whether or not task has previously been queued. If this parameter is True, then the task may have been previously queued (scheduled); if False, then the task is known not to have been queued, and this call is being made in order to execute the task inline without queuing it.</param>
		/// <returns>A Boolean value indicating whether the task was executed inline.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="task" /> was already executed.</exception>
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			return false;
		}

		/// <summary>Attempts to dequeue a <see cref="T:System.Threading.Tasks.Task" /> that was previously queued to this scheduler.</summary>
		/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be dequeued.</param>
		/// <returns>A Boolean denoting whether the <paramref name="task" /> argument was successfully dequeued.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		protected internal virtual bool TryDequeue(Task task)
		{
			return false;
		}

		internal virtual void NotifyWorkItemProgress()
		{
		}

		/// <summary>Initializes the <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		protected TaskScheduler()
		{
		}

		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
		}
	}
}
