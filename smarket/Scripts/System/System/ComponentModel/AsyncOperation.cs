using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Tracks the lifetime of an asynchronous operation.</summary>
	public sealed class AsyncOperation
	{
		private readonly SynchronizationContext _syncContext;

		private readonly object _userSuppliedState;

		private bool _alreadyCompleted;

		/// <summary>Gets or sets an object used to uniquely identify an asynchronous operation.</summary>
		/// <returns>The state object passed to the asynchronous method invocation.</returns>
		public object UserSuppliedState => null;

		/// <summary>Gets the <see cref="T:System.Threading.SynchronizationContext" /> object that was passed to the constructor.</summary>
		/// <returns>The <see cref="T:System.Threading.SynchronizationContext" /> object that was passed to the constructor.</returns>
		public SynchronizationContext SynchronizationContext => null;

		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
		}

		/// <summary>Finalizes the asynchronous operation.</summary>
		~AsyncOperation()
		{
		}

		/// <summary>Invokes a delegate on the thread or context appropriate for the application model.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.ComponentModel.AsyncOperation.PostOperationCompleted(System.Threading.SendOrPostCallback,System.Object)" /> method has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="d" /> is <see langword="null" />. </exception>
		public void Post(SendOrPostCallback d, object arg)
		{
		}

		/// <summary>Ends the lifetime of an asynchronous operation.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.ComponentModel.AsyncOperation.OperationCompleted" /> has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="d" /> is <see langword="null" />. </exception>
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
		}

		/// <summary>Ends the lifetime of an asynchronous operation.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.ComponentModel.AsyncOperation.OperationCompleted" /> has been called previously for this task. </exception>
		public void OperationCompleted()
		{
		}

		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
		}

		private void OperationCompletedCore()
		{
		}

		private void VerifyNotCompleted()
		{
		}

		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
		}

		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			return null;
		}

		internal AsyncOperation()
		{
		}
	}
}
