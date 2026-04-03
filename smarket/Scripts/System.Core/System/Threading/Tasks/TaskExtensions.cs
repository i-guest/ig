namespace System.Threading.Tasks
{
	/// <summary>Provides a set of static (Shared in Visual Basic) methods for working with specific kinds of <see cref="T:System.Threading.Tasks.Task" /> instances.</summary>
	public static class TaskExtensions
	{
		/// <summary>Creates a proxy <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation of a <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) or <see langword="Task (Of Task(Of T))" /> (Visual Basic).</summary>
		/// <param name="task">The <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) or <see langword="Task (Of Task(Of T))" /> (Visual Basic) to unwrap.</param>
		/// <typeparam name="TResult">The type of the task's result.</typeparam>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation of the provided <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) or <see langword="Task (Of Task(Of T))" /> (Visual Basic).</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown if the <paramref name="task" /> argument is null.</exception>
		public static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task)
		{
			return null;
		}
	}
}
